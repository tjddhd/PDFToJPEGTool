namespace PDFToJPEGTool
{
    partial class frmPDFToJPEGTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeMsg = new System.Windows.Forms.Label();
            this.txtSingleFilePath = new System.Windows.Forms.TextBox();
            this.lblSingleFilePath = new System.Windows.Forms.Label();
            this.lblInstructions1 = new System.Windows.Forms.Label();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.lblInstructions3 = new System.Windows.Forms.Label();
            this.btnBrowseSingleFile = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMultFileDir = new System.Windows.Forms.Label();
            this.txtMultFilePath = new System.Windows.Forms.TextBox();
            this.btnMultFileDir = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeMsg
            // 
            this.lblWelcomeMsg.AutoSize = true;
            this.lblWelcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg.Location = new System.Drawing.Point(24, 19);
            this.lblWelcomeMsg.Name = "lblWelcomeMsg";
            this.lblWelcomeMsg.Size = new System.Drawing.Size(339, 17);
            this.lblWelcomeMsg.TabIndex = 0;
            this.lblWelcomeMsg.Text = "Welcome to the PDF To JPEG Tool converter!";
            // 
            // txtSingleFilePath
            // 
            this.txtSingleFilePath.Location = new System.Drawing.Point(27, 128);
            this.txtSingleFilePath.Name = "txtSingleFilePath";
            this.txtSingleFilePath.Size = new System.Drawing.Size(315, 20);
            this.txtSingleFilePath.TabIndex = 1;
            // 
            // lblSingleFilePath
            // 
            this.lblSingleFilePath.AutoSize = true;
            this.lblSingleFilePath.Location = new System.Drawing.Point(24, 112);
            this.lblSingleFilePath.Name = "lblSingleFilePath";
            this.lblSingleFilePath.Size = new System.Drawing.Size(83, 13);
            this.lblSingleFilePath.TabIndex = 2;
            this.lblSingleFilePath.Text = "Single File Path:";
            // 
            // lblInstructions1
            // 
            this.lblInstructions1.AutoSize = true;
            this.lblInstructions1.Location = new System.Drawing.Point(24, 54);
            this.lblInstructions1.Name = "lblInstructions1";
            this.lblInstructions1.Size = new System.Drawing.Size(136, 13);
            this.lblInstructions1.TabIndex = 3;
            this.lblInstructions1.Text = "Select the File Path below. ";
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Location = new System.Drawing.Point(24, 67);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(275, 13);
            this.lblInstructions2.TabIndex = 4;
            this.lblInstructions2.Text = "If you select a single PDF, only that file will be converted.";
            // 
            // lblInstructions3
            // 
            this.lblInstructions3.AutoSize = true;
            this.lblInstructions3.Location = new System.Drawing.Point(24, 80);
            this.lblInstructions3.Name = "lblInstructions3";
            this.lblInstructions3.Size = new System.Drawing.Size(310, 13);
            this.lblInstructions3.TabIndex = 5;
            this.lblInstructions3.Text = "If you select a directory with multiple PDFs, all will be converted .";
            // 
            // btnBrowseSingleFile
            // 
            this.btnBrowseSingleFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSingleFile.Location = new System.Drawing.Point(348, 128);
            this.btnBrowseSingleFile.Name = "btnBrowseSingleFile";
            this.btnBrowseSingleFile.Size = new System.Drawing.Size(29, 20);
            this.btnBrowseSingleFile.TabIndex = 6;
            this.btnBrowseSingleFile.Text = "...";
            this.btnBrowseSingleFile.UseVisualStyleBackColor = true;
            this.btnBrowseSingleFile.Click += new System.EventHandler(this.btnBrowseSingleFile_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(27, 232);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnCnvert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblMultFileDir
            // 
            this.lblMultFileDir.AutoSize = true;
            this.lblMultFileDir.Location = new System.Drawing.Point(24, 172);
            this.lblMultFileDir.Name = "lblMultFileDir";
            this.lblMultFileDir.Size = new System.Drawing.Size(110, 13);
            this.lblMultFileDir.TabIndex = 8;
            this.lblMultFileDir.Text = "Multiple File Directory:";
            // 
            // txtMultFilePath
            // 
            this.txtMultFilePath.Location = new System.Drawing.Point(27, 189);
            this.txtMultFilePath.Name = "txtMultFilePath";
            this.txtMultFilePath.Size = new System.Drawing.Size(315, 20);
            this.txtMultFilePath.TabIndex = 9;
            // 
            // btnMultFileDir
            // 
            this.btnMultFileDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultFileDir.Location = new System.Drawing.Point(348, 189);
            this.btnMultFileDir.Name = "btnMultFileDir";
            this.btnMultFileDir.Size = new System.Drawing.Size(29, 23);
            this.btnMultFileDir.TabIndex = 10;
            this.btnMultFileDir.Text = "...";
            this.btnMultFileDir.UseVisualStyleBackColor = true;
            this.btnMultFileDir.Click += new System.EventHandler(this.btnMultFileDir_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(267, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPDFToJPEGTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 267);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMultFileDir);
            this.Controls.Add(this.txtMultFilePath);
            this.Controls.Add(this.lblMultFileDir);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowseSingleFile);
            this.Controls.Add(this.lblInstructions3);
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.lblInstructions1);
            this.Controls.Add(this.lblSingleFilePath);
            this.Controls.Add(this.txtSingleFilePath);
            this.Controls.Add(this.lblWelcomeMsg);
            this.Name = "frmPDFToJPEGTool";
            this.Text = "PDFToJPEGTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMsg;
        private System.Windows.Forms.TextBox txtSingleFilePath;
        private System.Windows.Forms.Label lblSingleFilePath;
        private System.Windows.Forms.Label lblInstructions1;
        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.Label lblInstructions3;
        private System.Windows.Forms.Button btnBrowseSingleFile;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblMultFileDir;
        private System.Windows.Forms.TextBox txtMultFilePath;
        private System.Windows.Forms.Button btnMultFileDir;
        private System.Windows.Forms.Button btnExit;
    }
}

