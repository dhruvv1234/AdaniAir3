using Sitecore.Data.Fields;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;
using AdaniAir.Feature.Hero.Models;

namespace AdaniAir.Feature.Hero.Controllers
{
    public class BannerController : Controller
    {
        public ActionResult Index()
        {
            var model = new Banner();
            var dataSourceId = RenderingContext.Current.Rendering.DataSource;
            var dataSourceItem = Sitecore.Context.Database.GetItem(dataSourceId);

            if (dataSourceItem != null)
            {
                model.Text1 = dataSourceItem["Text1"];
                model.Text2 = dataSourceItem["Text2"];
                model.DateText1 = dataSourceItem["Datetxt"];
                model.DateText2 = dataSourceItem["Datetxt2"];
                model.SearchButtonText = dataSourceItem["SearchBtntxt"];
                model.Stickytext1 = dataSourceItem["Stickytext1"];
                model.Stickytext2 = dataSourceItem["Stickytext2"];

                Field imageField1 = dataSourceItem.Fields["Image1"];
                if (imageField1 != null && imageField1.TypeKey == "image")
                {
                    var imageField = new ImageField(imageField1);
                    if (imageField.MediaItem != null)
                    {
                        model.ImageUrl1 = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                        model.ImageAltText1 = imageField.Alt;
                    }
                }

                Field imageField2 = dataSourceItem.Fields["Image2"];
                if (imageField2 != null && imageField2.TypeKey == "image")
                {
                    var imageField = new ImageField(imageField2);
                    if (imageField.MediaItem != null)
                    {
                        model.ImageUrl2 = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                        model.ImageAltText2 = imageField.Alt;
                    }
                }

                Field calendarImageField = dataSourceItem.Fields["Imgcalender"];
                if (calendarImageField != null && calendarImageField.TypeKey == "image")
                {
                    var imageField = new ImageField(calendarImageField);
                    if (imageField.MediaItem != null)
                    {
                        model.CalendarImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                        model.CalendarAltText = imageField.Alt;
                    }
                }

                
                Field ImageBot = dataSourceItem.Fields["ImageBot"];
                if (ImageBot != null && ImageBot.TypeKey == "image")
                {
                    var imageField = new ImageField(ImageBot);
                    if (imageField.MediaItem != null)
                    {
                        model.ImageBot = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                    }
                }
                Field StickyImg1 = dataSourceItem.Fields["StickyImg1"];
                if (StickyImg1 != null && StickyImg1.TypeKey == "image")
                {
                    var imageField = new ImageField(StickyImg1);
                    if (imageField.MediaItem != null)
                    {
                        model.StickyImg1 = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                    }
                }
                Field StickyImg2 = dataSourceItem.Fields["StickyImg2"];
                if (StickyImg2 != null && StickyImg2.TypeKey == "image")
                {
                    var imageField = new ImageField(StickyImg2);
                    if (imageField.MediaItem != null)
                    {
                        model.StickyImg2 = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                    }
                }
            }

            return View(model);
        }
    }
}