using System.Collections.Generic;
using YoutubeExtractor;

namespace YouTubeDownloader
{
    public class YouTubeModel
    {
        public YouTubeModel(string link, string folderpath)
        {
            Link = link;
            FolderPath = folderpath;
        }

        public IEnumerable<VideoInfo> VideoInfo { get; set; }
        public string FolderPath { get; set; }
        public string Link { get; set; }
        public string FilePath { get; set; }
        public VideoInfo Video { get; set; }
    }

    public class YouTubeVideo : YouTubeModel
    {
        public YouTubeVideo(string link, string folderpath) : base(link, folderpath)
        {
        }

        public VideoDownloader VideoDownloaderType { get; set; }
    }
}