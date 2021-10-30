using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Anipat.Controller
{
    public class SocialMediasController:SurfaceController
    {
        public ActionResult RenderSocialMedias()
        {
            var site = UmbracoContext.PublishedRequest.PublishedContent.Parent;
            return PartialView("SocialMedias",site);
        }
    }
}