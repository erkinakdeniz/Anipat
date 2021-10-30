using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Anipat.Controller
{
    public class AdaptController:SurfaceController
    {
        public ActionResult RenderAdapt()
        {
            var site = UmbracoContext.PublishedRequest.PublishedContent.Parent;
            return PartialView("AdaptPage",site);
        }
    }
}