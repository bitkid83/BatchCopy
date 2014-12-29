using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchCopy
{
    public partial class Form1 : Form
    {
        public String InputFileName = "";
        public String OutputFileName = "";

        public Form1()
        {
            InitializeComponent();

            //File -> Input...
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click);
            //File -> Output...
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.outputToolStripMenuItem_Click);
            //File -> Exit
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            
            //Go button click
            this.btnGoButton.Click += new System.EventHandler(this.btnGoButton_Click);

            this.txbxFileInputName.Click += new System.EventHandler(this.inputToolStripMenuItem_Click);
            this.txbxFileOutputName.Click += new System.EventHandler(this.outputToolStripMenuItem_Click);
            //this.txbxFileOutputName.TextChanged += txbxFileOutputName_TextChanged; //Text changed in Output File Name
            //this.txbxFileOutputName.KeyDown += txbxFileOutputName_TextChanged; //Press enter in the Output File Name
        }

        //File Menu -> Exit (quit the application)
        void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Environment.Exit(1);
        }

        //File Menu -> Input... (or click on the File Input text field)
        void inputToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.openFileDialogInput.ShowDialog();
            if (this.openFileDialogInput.FileName != "openFileDialog1")
            {
                this.txbxFileInputName.Text = this.openFileDialogInput.FileName;
                InputFileName = this.openFileDialogInput.FileName;
            }
        }

        //File Menu -> Output... (or click on the File Output text field)
        void outputToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.folderBrowserDialogOutput.ShowDialog();
            if (this.folderBrowserDialogOutput.SelectedPath != "")
            {
                this.txbxFileOutputName.Text = this.folderBrowserDialogOutput.SelectedPath + "\\";
                OutputFileName = this.folderBrowserDialogOutput.SelectedPath + "\\";
            }
        }

        void btnGoButton_Click(object sender, System.EventArgs e)
        {
            String prefix, extension;
            prefix = Path.GetFileNameWithoutExtension(InputFileName);
            extension = Path.GetExtension(InputFileName);
            for (int i = 0; i <= System.Convert.ToInt32(txbxNumberOfCopies.Text); i++)
            {
                File.Copy(InputFileName, OutputFileName + prefix + "_" + i.ToString() + extension);
            }
        }
    }
}
