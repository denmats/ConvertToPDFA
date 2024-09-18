namespace ConvertToPDFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFilePath = new TextBox();
            btnSelectFile = new Button();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(69, 51);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(670, 23);
            txtFilePath.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(69, 171);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(158, 23);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "Convert to PDF/A";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(69, 108);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(158, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Select File";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 281);
            Controls.Add(btnConvert);
            Controls.Add(btnSelectFile);
            Controls.Add(txtFilePath);
            Name = "Form1";
            Text = "PDF to PDF/A Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Button btnSelectFile;
        private Button btnConvert;
    }
}
