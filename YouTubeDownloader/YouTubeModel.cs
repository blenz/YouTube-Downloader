using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExtractor;

namespace YouTubeDownloader
{
    public class YouTubeModel
    {
        public IEnumerable<VideoInfo> VideoInfo { get; set; }
        public string FolderPath { get; set; }
        public string Link { get; set; }
        public string FilePath { get; set; }
        public VideoInfo Video { get; set; }
    }

    public class YouTubeVideo : YouTubeModel
    {
        public VideoDownloader VideoDownloader { get; set; }
    }

    public class YouTubeAudio : YouTubeModel
    {
        public AudioDownloader AudioDownloader { get; set; }
    }
}
