namespace YouTubeDownloader
{
    partial class YouTubeDLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTubeDLForm));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblDownloadPath = new System.Windows.Forms.Label();
            this.txtDownloadPath = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.chkOpenAfterDownload = new System.Windows.Forms.CheckBox();
            this.lblYouTubeURL = new System.Windows.Forms.Label();
            this.txtYouTubeURL = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblCurrentFileStatus = new System.Windows.Forms.Label();
            this.lblFileDownloading = new System.Windows.Forms.Label();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.pgDownload = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblValidation = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(542, 63);
            this.picBox.Margin = new System.Windows.Forms.Padding(6);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(302, 140);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblDownloadPath
            // 
            this.lblDownloadPath.AutoSize = true;
            this.lblDownloadPath.Location = new System.Drawing.Point(36, 223);
            this.lblDownloadPath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDownloadPath.Name = "lblDownloadPath";
            this.lblDownloadPath.Size = new System.Drawing.Size(163, 25);
            this.lblDownloadPath.TabIndex = 1;
            this.lblDownloadPath.Text = "Download Path:";
            // 
            // txtDownloadPath
            // 
            this.txtDownloadPath.Location = new System.Drawing.Point(252, 223);
            this.txtDownloadPath.Margin = new System.Windows.Forms.Padding(6);
            this.txtDownloadPath.Name = "txtDownloadPath";
            this.txtDownloadPath.Size = new System.Drawing.Size(650, 31);
            this.txtDownloadPath.TabIndex = 2;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(918, 223);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(6);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(150, 44);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // chkOpenAfterDownload
            // 
            this.chkOpenAfterDownload.AutoSize = true;
            this.chkOpenAfterDownload.Checked = true;
            this.chkOpenAfterDownload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpenAfterDownload.Location = new System.Drawing.Point(1094, 223);
            this.chkOpenAfterDownload.Margin = new System.Windows.Forms.Padding(6);
            this.chkOpenAfterDownload.Name = "chkOpenAfterDownload";
            this.chkOpenAfterDownload.Size = new System.Drawing.Size(248, 29);
            this.chkOpenAfterDownload.TabIndex = 4;
            this.chkOpenAfterDownload.Text = "Open After Download";
            this.chkOpenAfterDownload.UseVisualStyleBackColor = true;
            // 
            // lblYouTubeURL
            // 
            this.lblYouTubeURL.AutoSize = true;
            this.lblYouTubeURL.Location = new System.Drawing.Point(36, 283);
            this.lblYouTubeURL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYouTubeURL.Name = "lblYouTubeURL";
            this.lblYouTubeURL.Size = new System.Drawing.Size(154, 25);
            this.lblYouTubeURL.TabIndex = 5;
            this.lblYouTubeURL.Text = "YouTube URL:";
            // 
            // txtYouTubeURL
            // 
            this.txtYouTubeURL.Location = new System.Drawing.Point(252, 283);
            this.txtYouTubeURL.Margin = new System.Windows.Forms.Padding(6);
            this.txtYouTubeURL.Name = "txtYouTubeURL";
            this.txtYouTubeURL.Size = new System.Drawing.Size(650, 31);
            this.txtYouTubeURL.TabIndex = 6;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(918, 279);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(6);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(150, 44);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblCurrentFileStatus
            // 
            this.lblCurrentFileStatus.AutoSize = true;
            this.lblCurrentFileStatus.Location = new System.Drawing.Point(36, 350);
            this.lblCurrentFileStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurrentFileStatus.Name = "lblCurrentFileStatus";
            this.lblCurrentFileStatus.Size = new System.Drawing.Size(183, 25);
            this.lblCurrentFileStatus.TabIndex = 9;
            this.lblCurrentFileStatus.Text = "File Downloading:";
            // 
            // lblFileDownloading
            // 
            this.lblFileDownloading.AutoSize = true;
            this.lblFileDownloading.Location = new System.Drawing.Point(230, 350);
            this.lblFileDownloading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFileDownloading.Name = "lblFileDownloading";
            this.lblFileDownloading.Size = new System.Drawing.Size(0, 25);
            this.lblFileDownloading.TabIndex = 10;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Location = new System.Drawing.Point(36, 413);
            this.lblProgressBar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(205, 25);
            this.lblProgressBar.TabIndex = 11;
            this.lblProgressBar.Text = "Download Progress:";
            // 
            // pgDownload
            // 
            this.pgDownload.Location = new System.Drawing.Point(252, 413);
            this.pgDownload.Margin = new System.Windows.Forms.Padding(6);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Size = new System.Drawing.Size(992, 25);
            this.pgDownload.TabIndex = 12;
            // 
            // lblValidation
            // 
            this.lblValidation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValidation.Location = new System.Drawing.Point(567, 461);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(302, 41);
            this.lblValidation.TabIndex = 13;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(1253, 413);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(43, 25);
            this.lblPercent.TabIndex = 14;
            this.lblPercent.Text = "0%";
            // 
            // YouTubeDLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 502);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblValidation);
            this.Controls.Add(this.pgDownload);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.lblFileDownloading);
            this.Controls.Add(this.lblCurrentFileStatus);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtYouTubeURL);
            this.Controls.Add(this.lblYouTubeURL);
            this.Controls.Add(this.chkOpenAfterDownload);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtDownloadPath);
            this.Controls.Add(this.lblDownloadPath);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "YouTubeDLForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "YouTube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblDownloadPath;
        private System.Windows.Forms.TextBox txtDownloadPath;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.CheckBox chkOpenAfterDownload;
        private System.Windows.Forms.Label lblYouTubeURL;
        private System.Windows.Forms.TextBox txtYouTubeURL;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblCurrentFileStatus;
        private System.Windows.Forms.Label lblFileDownloading;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.ProgressBar pgDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Label lblPercent;
    }
}

