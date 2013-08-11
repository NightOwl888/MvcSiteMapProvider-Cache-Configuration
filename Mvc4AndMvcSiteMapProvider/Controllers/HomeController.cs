using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4AndMvcSiteMapProvider.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            // Invalidate the cache
            MvcSiteMapProvider.SiteMaps.ReleaseSiteMap();

            ViewBag.Message = "The cache was reset.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SiteMap()
        {
            ViewBag.Message = "A map of our site.";

            return View();
        }
    }
}
