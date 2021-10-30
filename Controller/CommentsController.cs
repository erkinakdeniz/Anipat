using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Anipat.Controller
{
    public class CommentsController:SurfaceController
    {
        public ActionResult RenderComment()
        {
            var site = UmbracoContext.PublishedRequest.PublishedContent.Parent;
            return PartialView("Comments",site);
        }
    }
}