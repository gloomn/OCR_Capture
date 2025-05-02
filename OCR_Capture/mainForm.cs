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

        private void extractButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Bitmap img = new Bitmap(filePathTextBox.Text))
                {
                    using (var page = ocr.Process(img))
                    {
                        extractedText.Text = page.GetText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

    }
}
