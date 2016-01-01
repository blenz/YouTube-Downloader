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
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblCurrentFileStatus = new System.Windows.Forms.Label();
            this.lblFileDownloading = new System.Windows.Forms.Label();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.pgDownload = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(271, 33);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(151, 73);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblDownloadPath
            // 
            this.lblDownloadPath.AutoSize = true;
            this.lblDownloadPath.Location = new System.Drawing.Point(18, 116);
            this.lblDownloadPath.Name = "lblDownloadPath";
            this.lblDownloadPath.Size = new System.Drawing.Size(83, 13);
            this.lblDownloadPath.TabIndex = 1;
            this.lblDownloadPath.Text = "Download Path:";
            // 
            // txtDownloadPath
            // 
            this.txtDownloadPath.Location = new System.Drawing.Point(126, 116);
            this.txtDownloadPath.Name = "txtDownloadPath";
            this.txtDownloadPath.Size = new System.Drawing.Size(327, 20);
            this.txtDownloadPath.TabIndex = 2;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(459, 116);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // chkOpenAfterDownload
            // 
            this.chkOpenAfterDownload.AutoSize = true;
            this.chkOpenAfterDownload.Location = new System.Drawing.Point(547, 116);
            this.chkOpenAfterDownload.Name = "chkOpenAfterDownload";
            this.chkOpenAfterDownload.Size = new System.Drawing.Size(128, 17);
            this.chkOpenAfterDownload.TabIndex = 4;
            this.chkOpenAfterDownload.Text = "Open After Download";
            this.chkOpenAfterDownload.UseVisualStyleBackColor = true;
            // 
            // lblYouTubeURL
            // 
            this.lblYouTubeURL.AutoSize = true;
            this.lblYouTubeURL.Location = new System.Drawing.Point(18, 147);
            this.lblYouTubeURL.Name = "lblYouTubeURL";
            this.lblYouTubeURL.Size = new System.Drawing.Size(79, 13);
            this.lblYouTubeURL.TabIndex = 5;
            this.lblYouTubeURL.Text = "YouTube URL:";
            // 
            // txtYouTubeURL
            // 
            this.txtYouTubeURL.Location = new System.Drawing.Point(126, 147);
            this.txtYouTubeURL.Name = "txtYouTubeURL";
            this.txtYouTubeURL.Size = new System.Drawing.Size(327, 20);
            this.txtYouTubeURL.TabIndex = 6;
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Location = new System.Drawing.Point(459, 147);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(74, 21);
            this.comboBoxFileType.TabIndex = 7;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(547, 147);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // lblCurrentFileStatus
            // 
            this.lblCurrentFileStatus.AutoSize = true;
            this.lblCurrentFileStatus.Location = new System.Drawing.Point(18, 182);
            this.lblCurrentFileStatus.Name = "lblCurrentFileStatus";
            this.lblCurrentFileStatus.Size = new System.Drawing.Size(91, 13);
            this.lblCurrentFileStatus.TabIndex = 9;
            this.lblCurrentFileStatus.Text = "File Downloading:";
            // 
            // lblFileDownloading
            // 
            this.lblFileDownloading.AutoSize = true;
            this.lblFileDownloading.Location = new System.Drawing.Point(115, 182);
            this.lblFileDownloading.Name = "lblFileDownloading";
            this.lblFileDownloading.Size = new System.Drawing.Size(35, 13);
            this.lblFileDownloading.TabIndex = 10;
            this.lblFileDownloading.Text = "label1";
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Location = new System.Drawing.Point(18, 215);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(102, 13);
            this.lblProgressBar.TabIndex = 11;
            this.lblProgressBar.Text = "Download Progress:";
            // 
            // pgDownload
            // 
            this.pgDownload.Location = new System.Drawing.Point(126, 215);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Size = new System.Drawing.Size(389, 13);
            this.pgDownload.TabIndex = 12;
            // 
            // YouTubeDLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 261);
            this.Controls.Add(this.pgDownload);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.lblFileDownloading);
            this.Controls.Add(this.lblCurrentFileStatus);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.comboBoxFileType);
            this.Controls.Add(this.txtYouTubeURL);
            this.Controls.Add(this.lblYouTubeURL);
            this.Controls.Add(this.chkOpenAfterDownload);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtDownloadPath);
            this.Controls.Add(this.lblDownloadPath);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ComboBox comboBoxFileType;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblCurrentFileStatus;
        private System.Windows.Forms.Label lblFileDownloading;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.ProgressBar pgDownload;
    }
}

