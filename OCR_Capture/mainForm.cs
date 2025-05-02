using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace OCR_Capture
{
    public partial class mainForm : Form
    {
        TesseractEngine ocr = new TesseractEngine("./tessdata", "kor", EngineMode.Default);
        string filePath;

        public mainForm()
        {
            InitializeComponent();
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.*";
            ofd.InitialDirectory = ".";
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.tif;*.tiff|All Files|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                filePathTextBox.Text = filePath;
            }
        }

        private async void extractButton_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            string result = "";

            // 진행률 가짜로 증가시키는 타이머
            var progressTimer = new System.Windows.Forms.Timer();
            progressTimer.Interval = 50;
            progressTimer.Tick += (s, args) =>
            {
                if (progressBar1.Value < 95)
                    progressBar1.Value += 1;
            };
            progressTimer.Start();

            try
            {
                await Task.Run(() =>
                {
                    using (Bitmap img = new Bitmap(filePathTextBox.Text))
                    {
                        using (var page = ocr.Process(img))
                        {
                            result = page.GetText();
                        }
                    }
                });

                extractedText.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                // 진행률 바로 100%로, 타이머 종료
                progressTimer.Stop();
                progressBar1.Value = 100;

                // 약간 딜레이 후 숨김 (시각적 효과)
                await Task.Delay(500);
                progressBar1.Visible = false;
            }
        }


    }
}
