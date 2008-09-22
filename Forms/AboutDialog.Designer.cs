﻿namespace Ketarin.Forms
{
    partial class AboutDialog
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
            this.bClose = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblVersionDesc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblImagesExcluded = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lnkKetarin = new System.Windows.Forms.LinkLabel();
            this.lnkGPL = new CDBurnerXP.Controls.WebLink();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(182, 119);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(227, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Ketarin: Keep your setup packages up-to-date.";
            // 
            // lblVersionDesc
            // 
            this.lblVersionDesc.AutoSize = true;
            this.lblVersionDesc.Location = new System.Drawing.Point(3, 0);
            this.lblVersionDesc.Name = "lblVersionDesc";
            this.lblVersionDesc.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblVersionDesc.Size = new System.Drawing.Size(47, 17);
            this.lblVersionDesc.TabIndex = 2;
            this.lblVersionDesc.Text = "Version:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblVersionDesc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVersion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnkGPL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLicense, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblImagesExcluded, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWebsite, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lnkKetarin, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 88);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(60, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblVersion.Size = new System.Drawing.Size(2, 17);
            this.lblVersion.TabIndex = 3;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(3, 17);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblLicense.Size = new System.Drawing.Size(49, 17);
            this.lblLicense.TabIndex = 3;
            this.lblLicense.Text = "License:";
            // 
            // lblImagesExcluded
            // 
            this.lblImagesExcluded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagesExcluded.Location = new System.Drawing.Point(60, 34);
            this.lblImagesExcluded.Name = "lblImagesExcluded";
            this.lblImagesExcluded.Size = new System.Drawing.Size(182, 32);
            this.lblImagesExcluded.TabIndex = 5;
            this.lblImagesExcluded.Text = "This excludes the used icons, which are copyrighted by  VirtualLNK, LLC.";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(3, 66);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblWebsite.Size = new System.Drawing.Size(51, 17);
            this.lblWebsite.TabIndex = 6;
            this.lblWebsite.Text = "Website:";
            // 
            // lnkKetarin
            // 
            this.lnkKetarin.AutoSize = true;
            this.lnkKetarin.Location = new System.Drawing.Point(60, 66);
            this.lnkKetarin.Name = "lnkKetarin";
            this.lnkKetarin.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lnkKetarin.Size = new System.Drawing.Size(155, 17);
            this.lnkKetarin.TabIndex = 7;
            this.lnkKetarin.TabStop = true;
            this.lnkKetarin.Text = "http://ketarin.canneverbe.com";
            // 
            // lnkGPL
            // 
            this.lnkGPL.AutoSize = true;
            this.lnkGPL.Location = new System.Drawing.Point(60, 17);
            this.lnkGPL.Name = "lnkGPL";
            this.lnkGPL.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lnkGPL.Size = new System.Drawing.Size(75, 17);
            this.lnkGPL.TabIndex = 4;
            this.lnkGPL.TabStop = true;
            this.lnkGPL.Text = "GNU GPL v.2";
            this.lnkGPL.Url = "http://www.gnu.org/licenses/gpl-2.0.txt";
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 154);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.bClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblVersionDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVersion;
        private CDBurnerXP.Controls.WebLink lnkGPL;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblImagesExcluded;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.LinkLabel lnkKetarin;
    }
}