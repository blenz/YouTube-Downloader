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
using YoutubeExtractor;

namespace YouTubeDownloader
{
    public partial class YouTubeDLForm : Form
    {
        public YouTubeDLForm()
        {
            InitializeComponent();

            // Set video as default
            comboBoxFileType.SelectedIndex = 0;

            // Get Path
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Set Path
            folderBrowserDialog1.SelectedPath = folder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
                txtDownloadPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            // Our test youtube link
            string link = "https://www.youtube.com/watch?v=626fsEM1Cts";

            /*
             * Get the available video formats.
             * We'll work with them in the video and audio download examples.
             */
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);

            /*
             * Select the first .mp4 video with 360p resolution
             */
            VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 720);

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the video downloader.
             * The first argument is the video to download.
             * The second argument is the path to save the video file.
             */
            var videoDownloader = new VideoDownloader(video, Path.Combine(txtDownloadPath.Text, video.Title + video.VideoExtension));

            // Register the ProgressChanged event and print the current progress
            //videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);

            /*
             * Execute the video downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            videoDownloader.Execute();
        }
    }
}
