using System.Collections.Generic;

namespace AdaniAir.Feature.Hero.Models
{
    public class ShopSection
    {
        public string TitleMain { get; set; }
        public string SubtitleMain { get; set; }
        public List<ShopSection> ShopList { get; set; } = new List<ShopSection>();

        // Properties for each shop item
        public string ShopTitle { get; set; }
        public string ShopSubtitle { get; set; }
        public string ShopImageUrl { get; set; }
    }
}
