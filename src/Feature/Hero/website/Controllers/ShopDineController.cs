using AdaniAir.Feature.Hero.Models;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;

namespace AdaniAir.Feature.Hero.Controllers
{
    public class ShopDineController : Controller
    {
        public ActionResult Index()
        {
            var model = new ShopSection();
            var datasourceId = RenderingContext.Current.Rendering.DataSource;
            var datasourceItem = Sitecore.Context.Database.GetItem(datasourceId);

            if (datasourceItem != null)
            {
                model.TitleMain = datasourceItem["Title"];
                model.SubtitleMain = datasourceItem["Subtitle"];

                var treeListField = (MultilistField)datasourceItem.Fields["ShopList"];
                if (treeListField != null)
                {
                    foreach (var item in treeListField.GetItems())
                    {
                        var shopSection = new ShopSection
                        {
                            ShopTitle = item.Fields["ShopTitle"].Value,
                            ShopSubtitle = item.Fields["ShopSubtitle"].Value,
                            ShopImageUrl = GetImageUrl(item.Fields["ShopImage"]) // Get the image URL
                        };

                        model.ShopList.Add(shopSection);
                    }
                }
            }

            return View(model);
        }

        private string GetImageUrl(Field field)
        {
            if (field != null && field.TypeKey == "image")
            {
                var imageField = new ImageField(field);
                if (imageField.MediaItem != null)
                {
                    return Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                }
            }
            return null; // Return null if there's no image
        }
    }
}
