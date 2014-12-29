//using System.IO;

namespace BatchCopy
{
    partial class Form1
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
            this.btnGoButton = new System.Windows.Forms.Button();
            this.txbxNumberOfCopies = new System.Windows.Forms.TextBox();
            this.lblNumberOfCopies = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBatchCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogInput = new System.Windows.Forms.OpenFileDialog();
            this.txbxFileInputName = new System.Windows.Forms.TextBox();
            this.lblFileInput = new System.Windows.Forms.Label();
            this.lblFileOutput = new System.Windows.Forms.Label();
            this.txbxFileOutputName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoButton
            // 
            this.btnGoButton.Location = new System.Drawing.Point(115, 126);
            this.btnGoButton.Name = "btnGoButton";
            this.btnGoButton.Size = new System.Drawing.Size(75, 23);
            this.btnGoButton.TabIndex = 0;
            this.btnGoButton.Text = "Go";
            this.btnGoButton.UseVisualStyleBackColor = true;
            // 
            // txbxNumberOfCopies
            // 
            this.txbxNumberOfCopies.Location = new System.Drawing.Point(179, 95);
            this.txbxNumberOfCopies.Name = "txbxNumberOfCopies";
            this.txbxNumberOfCopies.Size = new System.Drawing.Size(48, 20);
            this.txbxNumberOfCopies.TabIndex = 1;
            this.txbxNumberOfCopies.Text = "50";
            // 
            // lblNumberOfCopies
            // 
            this.lblNumberOfCopies.AutoSize = true;
            this.lblNumberOfCopies.Location = new System.Drawing.Point(79, 99);
            this.lblNumberOfCopies.Name = "lblNumberOfCopies";
            this.lblNumberOfCopies.Size = new System.Drawing.Size(94, 13);
            this.lblNumberOfCopies.TabIndex = 2;
            this.lblNumberOfCopies.Text = "Number of Copies:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.inputToolStripMenuItem.Text = "Input...";
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.outputToolStripMenuItem.Text = "Output...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBatchCopyToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutBatchCopyToolStripMenuItem
            // 
            this.aboutBatchCopyToolStripMenuItem.Name = "aboutBatchCopyToolStripMenuItem";
            this.aboutBatchCopyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutBatchCopyToolStripMenuItem.Text = "About Batch Copy...";
            // 
            // openFileDialogInput
            // 
            this.openFileDialogInput.FileName = "openFileDialog1";
            // 
            // txbxFileInputName
            // 
            this.txbxFileInputName.Location = new System.Drawing.Point(63, 28);
            this.txbxFileInputName.Name = "txbxFileInputName";
            this.txbxFileInputName.Size = new System.Drawing.Size(226, 20);
            this.txbxFileInputName.TabIndex = 4;
            this.txbxFileInputName.Text = "Source...";
            // 
            // lblFileInput
            // 
            this.lblFileInput.AutoSize = true;
            this.lblFileInput.Location = new System.Drawing.Point(23, 31);
            this.lblFileInput.Name = "lblFileInput";
            this.lblFileInput.Size = new System.Drawing.Size(34, 13);
            this.lblFileInput.TabIndex = 5;
            this.lblFileInput.Text = "Input:";
            // 
            // lblFileOutput
            // 
            this.lblFileOutput.AutoSize = true;
            this.lblFileOutput.Location = new System.Drawing.Point(15, 66);
            this.lblFileOutput.Name = "lblFileOutput";
            this.lblFileOutput.Size = new System.Drawing.Size(42, 13);
            this.lblFileOutput.TabIndex = 6;
            this.lblFileOutput.Text = "Output:";
            // 
            // txbxFileOutputName
            // 
            this.txbxFileOutputName.Location = new System.Drawing.Point(63, 63);
            this.txbxFileOutputName.Name = "txbxFileOutputName";
            this.txbxFileOutputName.Size = new System.Drawing.Size(226, 20);
            this.txbxFileOutputName.TabIndex = 7;
            this.txbxFileOutputName.Text = "Destination...";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.txbxFileOutputName);
            this.Controls.Add(this.lblFileOutput);
            this.Controls.Add(this.lblFileInput);
            this.Controls.Add(this.txbxFileInputName);
            this.Controls.Add(this.lblNumberOfCopies);
            this.Controls.Add(this.txbxNumberOfCopies);
            this.Controls.Add(this.btnGoButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Batch Copy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button btnGoButton;
        private System.Windows.Forms.TextBox txbxNumberOfCopies;
        private System.Windows.Forms.Label lblNumberOfCopies;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBatchCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogInput;
        private System.Windows.Forms.TextBox txbxFileInputName;
        private System.Windows.Forms.Label lblFileInput;
        private System.Windows.Forms.Label lblFileOutput;
        private System.Windows.Forms.TextBox txbxFileOutputName;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
    }
}

