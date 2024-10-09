using AdaniAir.Project.AdaniAir.Models;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdaniAir.Project.AdaniAir.Controllers
{
    public class FlightSearchController : Controller
    {
        public ActionResult Index()
        {
            var model = new FlightSearchViewModel();
            var dataSourceId = RenderingContext.Current.Rendering.DataSource;
            var dataSourceItem = Sitecore.Context.Database.GetItem(dataSourceId);

            if (dataSourceItem != null)
            {
                model.Text2 = dataSourceItem["Text2"];
                model.DateText1 = dataSourceItem["Datetxt"];
                model.DateText2 = dataSourceItem["Datetxt2"];
                model.SearchButtonText = dataSourceItem["SearchBtntxt"];

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
            }

            return View(model);
        }
    }
}