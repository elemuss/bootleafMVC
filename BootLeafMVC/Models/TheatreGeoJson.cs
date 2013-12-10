using System.Collections.Generic;

namespace BootLeafMVC.Models
{
    public class TheatreGeoJson
    {
        public string type { get; set; }
        public List<TheatreFeature> features { get; set; }
    }
}