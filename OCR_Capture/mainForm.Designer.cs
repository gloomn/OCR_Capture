namespace OCR_Capture
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.extractedText = new System.Windows.Forms.TextBox();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.selectFolder = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // extractedText
            // 
            this.extractedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extractedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extractedText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractedText.Location = new System.Drawing.Point(690, 12);
            this.extractedText.Multiline = true;
            this.extractedText.Name = "extractedText";
            this.extractedText.Size = new System.Drawing.Size(476, 520);
            this.extractedText.TabIndex = 0;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePathTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(19, 63);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(604, 45);
            this.filePathTextBox.TabIndex = 1;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(12, 22);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(338, 38);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Select files to extract text";
            // 
            // selectFolder
            // 
            this.selectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFolder.FlatAppearance.BorderSize = 0;
            this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolder.Image = ((System.Drawing.Image)(resources.GetObject("selectFolder.Image")));
            this.selectFolder.Location = new System.Drawing.Point(629, 63);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(45, 45);
            this.selectFolder.TabIndex = 3;
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // extractButton
            // 
            this.extractButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.extractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractButton.ForeColor = System.Drawing.Color.White;
            this.extractButton.Location = new System.Drawing.Point(19, 459);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(604, 51);
            this.extractButton.TabIndex = 4;
            this.extractButton.Text = "Extract!";
            this.extractButton.UseVisualStyleBackColor = false;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // copyright
            // 
            this.copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.copyright.Location = new System.Drawing.Point(-3, 520);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(155, 22);
            this.copyright.TabIndex = 5;
            this.copyright.Text = " ⓒ Lee Ki Joon 2025";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.extractedText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "OCR_Capture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox extractedText;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Label copyright;
    }
}

