using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Anipat.Controller
{
    public class ServicesController:SurfaceController
    {
        public ActionResult RenderService()
        {
            var site = UmbracoContext.PublishedRequest.PublishedContent.Parent;
            return PartialView("Services",site);
        }
    }
}