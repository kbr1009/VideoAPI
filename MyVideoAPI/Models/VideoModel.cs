namespace MyVideoAPI.Models
{
    public class VideoModel
    {
        public long ID { get; set; }
        public string VideoName { get; set; }
        public string ThumbnailUrl { get; set; }
        public string VideoUrl { get; set; }
        public string TimeStamp { get; set; }
    }
}