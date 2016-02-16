using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore_03.Models;

namespace MVCMusicStore_03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //kwkwk 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Example()
        {
            return View("~/Views/Example/Index.cshtml");
        }

        public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album() { Title = "Album" + i });
            }
          
            return View(albums);
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Message()
        {
            ViewBag.Message = "This is a partial view.";
            return PartialView();
        }
    }
}