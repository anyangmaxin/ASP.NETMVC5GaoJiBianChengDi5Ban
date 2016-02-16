using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore_07.Controllers
{
    public class AntiXSSController : Controller
    {
        // GET: AntiXSS
        public ActionResult Index()
        {
            ViewBag.UserName = "Json,<script>alert('message');</script>";
            return View();
        }
    }
}