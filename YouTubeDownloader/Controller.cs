﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YouTubeDownloader
{
    public partial class YouTubeDLForm : Form
    {
        public YouTubeDLForm()
        {
            InitializeComponent();

            // Get Path
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Set Path
            folderBrowserDialog1.SelectedPath = folder;
        }

        private void Form1_Load(object sender, EventArgs e){}


        // Choose where to download
        private void btnChoose_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
                txtDownloadPath.Text = folderBrowserDialog1.SelectedPath;
        }

        // Download click
        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Check for valid input
            var validInput = ValidateInput();
  
            string link;
            string folderpath;

            // If input is valid else do nothing
            if (validInput.Item1)
            {
                link = validInput.Item2;
                folderpath = txtDownloadPath.Text;
                DisableUI();
            }
            else
                return;

            // Download Video
            DownloadVideo(new YouTubeVideo(link, folderpath));
        }

        
        // Download the video
        private void DownloadVideo(YouTubeVideo video)
        {
            try
            {
                // Get video information
                video.VideoInfo = FileDownloader.GetVideoInfos(video);
                video.Video = FileDownloader.GetVideoInfo(video);
                lblFileDownloading.Text = video.Video.Title;
                video.FilePath = FileDownloader.GetPath(video) + video.Video.VideoExtension;
                video.VideoDownloaderType = FileDownloader.GetVideoDownloader(video);

                // Open file location
                video.VideoDownloaderType.DownloadFinished += (sender, args) => OpenFolder(video.FilePath);

                // Download bar
                video.VideoDownloaderType.DownloadProgressChanged +=
                    (sender, args) => pgDownload.Value = (int) args.ProgressPercentage;
                video.VideoDownloaderType.DownloadProgressChanged +=
                    (sender, args) => lblPercent.Text = ((int) args.ProgressPercentage).ToString() + "%";

                // Allow user to use the UI after download is finished
                video.VideoDownloaderType.DownloadFinished += (sender, args) => EnableUI();

                CheckForIllegalCrossThreadCalls = false;

                // Download
                FileDownloader.DownloadVideo(video);
            }
            catch (Exception)
            {
                EnableUI();
                lblValidation.Text = "Error Downloading Video";
            }
        }
        
        

        // HELPERS

        private void OpenFolder(string filePath)
        {
            if (chkOpenAfterDownload.Checked)
            {
                var args = "/select, \"" + filePath + "\"";
                Process.Start("explorer.exe", args);
            }
        }

        private void DisableUI()
        {
            btnDownload.Enabled = false;
            btnChoose.Enabled = false;
            txtDownloadPath.Enabled = false;
            txtYouTubeURL.Enabled = false;
        }

        private void EnableUI()
        {
            btnDownload.Enabled = true;
            btnChoose.Enabled = true;
            txtDownloadPath.Enabled = true;
            txtYouTubeURL.Enabled = true; 
        }

        private Tuple<bool, string> ValidateInput()
        {
            string resultURL;
            var validURL = DownloadUrlResolver.TryNormalizeYoutubeUrl(txtYouTubeURL.Text, out resultURL);
            var validFolderPath = Directory.Exists(txtDownloadPath.Text);

            if (!validFolderPath)
            {
                lblValidation.Text = "Invalid Folder Path";
                lblValidation.ForeColor = Color.Red;
                return Tuple.Create(false, "");
            }

            if (!validURL)
            {
                lblValidation.Text = "Invalid URL";
                lblValidation.ForeColor = Color.Red;
                return Tuple.Create(false, "");
            }

            lblValidation.Text = "Valid URL / Folder Path";
            lblValidation.ForeColor = Color.Green;
            return Tuple.Create(true, resultURL);
        }
    }
}