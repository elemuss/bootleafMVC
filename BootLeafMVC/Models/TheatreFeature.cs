namespace BootLeafMVC.Models
{
    public class TheatreFeature
    {
        public string type { get; set; }
        public int id { get; set; }
        public Theatre properties { get; set; }
        public TheatreGeometry geometry { get; set; }
    }
}