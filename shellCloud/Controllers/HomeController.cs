using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shellCloud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Bienvenido a SkyNet";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
