using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ghostscript.NET.Processor;


namespace PDFToJPEGTool
{
    public partial class frmPDFToJPEGTool : Form
    {
        public frmPDFToJPEGTool()
        {
            InitializeComponent();
        }

        void ghostscriptProcessing(object sender, GhostscriptProcessorProcessingEventArgs e)
        {

        }

        private void ConvertToJPEG(string inputFileName)
        {
            Ghostscript.NET.GhostscriptVersionInfo gv = Ghostscript.NET.GhostscriptVersionInfo.GetLastInstalledVersion(Ghostscript.NET.GhostscriptLicense.GPL | Ghostscript.NET.GhostscriptLicense.AFPL, Ghostscript.NET.GhostscriptLicense.GPL);

            string outputPath = System.IO.Path.GetDirectoryName(inputFileName) + "\\" + System.IO.Path.GetFileNameWithoutExtension(inputFileName) + ".jpg";

            System.IO.StreamReader r = new System.IO.StreamReader(inputFileName);
            string pdfText = r.ReadToEnd();
            System.Text.RegularExpressions.Regex rx1 = new System.Text.RegularExpressions.Regex(@"/Type\s*/Page[^s]");
            System.Text.RegularExpressions.MatchCollection matches = rx1.Matches(pdfText);

            //GhostscriptSharp.GhostscriptWrapper.GenerateOutput(singleFilePath, outputPath, gss);

            using (GhostscriptProcessor gsp = new GhostscriptProcessor(gv, true))
            {
                gsp.Processing += new GhostscriptProcessorProcessingEventHandler(ghostscriptProcessing);

                List<string> switches = new List<string>();

                switches.Add("-empty");
                switches.Add("-dSAFER");
                switches.Add("-dBATCH");
                switches.Add("-dNOPAUSE");
                switches.Add("-dNOPROMPT");
                switches.Add(@"-sFONTPATH=" + System.Environment.GetFolderPath(System.Environment.SpecialFolder.Fonts));
                switches.Add("-dFirstPage=1");
                switches.Add("-dLastPage=" + matches.Count.ToString());
                switches.Add("-sDEVICE=jpeg");
                switches.Add("-r96");
                switches.Add("-dTextAlphaBits=4");
                switches.Add("-dGraphicsAlphaBits=4");
                switches.Add(@"-sOutputFile=" + outputPath);
                switches.Add(@"-f");
                switches.Add(inputFileName);

                gsp.StartProcessing(switches.ToArray(), null);
            }
        }

        private void btnCnvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtSingleFilePath.Text) && string.IsNullOrEmpty(this.txtMultFilePath.Text))
            {
                MessageBox.Show("You need to enter a file path!", "Error: No File Path");
                return;
            }

            string singleFilePath = this.txtSingleFilePath.Text, multFileDir = this.txtMultFilePath.Text;
            string pathsSelected = "Single File Path:\t\t" + singleFilePath + "\nMultiple File Directory:\t" + multFileDir;

            //GhostscriptSharp.GhostscriptSettings gss = new GhostscriptSharp.GhostscriptSettings();
            //gss.Device = GhostscriptSharp.Settings.GhostscriptDevices.jpeg;
            //gss.Page.AllPages = true;
            //gss.Resolution = new Size(500, 500);
            //gss.Size = new GhostscriptSharp.Settings.GhostscriptPageSize() { Native = GhostscriptSharp.Settings.GhostscriptPageSizes.a4, Manual = new Size(500, 500) };

            Ghostscript.NET.GhostscriptVersionInfo gv = Ghostscript.NET.GhostscriptVersionInfo.GetLastInstalledVersion(Ghostscript.NET.GhostscriptLicense.GPL | Ghostscript.NET.GhostscriptLicense.AFPL, Ghostscript.NET.GhostscriptLicense.GPL);

            MessageBox.Show(pathsSelected);

            if (!string.IsNullOrEmpty(singleFilePath))
            {
                if (!System.IO.File.Exists(singleFilePath))
                {
                    MessageBox.Show("The file you entered does not exist. Verify that it does and try again.\nYour entry:\t" + singleFilePath, "Single File does not exist");
                }
                else if (!string.Equals(System.IO.Path.GetExtension(singleFilePath), ".pdf"))
                {
                    MessageBox.Show("The file you entered is not a PDF. Verify that it is and try again.\nYour entry:\t" + singleFilePath, "Single File not PDF");
                }
                else
                {
                    Label lblWaitMsg = new Label();
                    lblWaitMsg.Location = new Point(13, 13);
                    lblWaitMsg.Text = "Please wait while the Image Conversion loads..";
                    lblWaitMsg.AutoSize = true;

                    System.Windows.Forms.Form frmWait = new Form();
                    frmWait.Text = "Loading...";
                    frmWait.UseWaitCursor = true;
                    frmWait.Controls.Add(lblWaitMsg);
                    frmWait.AutoSize = true;

                    frmWait.Show();
                    ConvertToJPEG(singleFilePath);
                    frmWait.Close();
                    MessageBox.Show("Single File conversion sucess!");
                }
            }

            if (!string.IsNullOrEmpty(multFileDir))
            {
                if (!System.IO.Directory.Exists(multFileDir))
                {
                    MessageBox.Show("The Directory you entered does not exist. Verify that it does and try again.\nYour entry:\t" + multFileDir, "File Directory does not exist");
                    return;
                }
                else
                {
                    System.IO.DirectoryInfo multiDirInfo = new System.IO.DirectoryInfo(multFileDir);
                    System.IO.FileInfo[] pdfFiles = multiDirInfo.GetFiles("*.pdf");

                    if (pdfFiles.Count() <= 0)
                    {
                        MessageBox.Show("The Directory you entered does not have any PDF files. Verify that it does and try again.\nYour entry:\t" + multFileDir, "File Directory conatins no PDFs");
                    }
                    else
                    {
                        Label lblWaitMsg = new Label();
                        lblWaitMsg.Location = new Point(13, 13);
                        lblWaitMsg.Text = "Please wait while the Image Conversion loads..";
                        lblWaitMsg.AutoSize = true;

                        System.Windows.Forms.Form frmWait = new Form();
                        frmWait.Text = "Loading...";
                        frmWait.UseWaitCursor = true;
                        frmWait.Controls.Add(lblWaitMsg);
                        frmWait.AutoSize = true;

                        frmWait.Show();

                        string multiFiles = "";

                        for (int counter = 0; counter < pdfFiles.Count(); counter++)
                        {
                            multiFiles = multiFiles + pdfFiles[counter].ToString() + "\n";
                            ConvertToJPEG(multiDirInfo.ToString() + "\\" + pdfFiles[counter].ToString());
                        }

                        frmWait.Close();

                        MessageBox.Show("Multiple File sucess!\n" + multiFiles);
                    }
                }
            }

            return;
        }

        private void btnBrowseSingleFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtSingleFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnMultFileDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtMultFilePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            Application.Exit();
        }
    }
}
