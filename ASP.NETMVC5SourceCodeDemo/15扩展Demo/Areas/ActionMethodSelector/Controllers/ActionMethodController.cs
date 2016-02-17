using System;
using System.Web.Mvc;
using _15扩展Demo.Areas.ActionMethodSelector.Utility;

namespace _15扩展Demo.Areas.ActionMethodSelector.Controllers
{
    public class ActionMethodController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AjaxOnly]
        public ActionResult Index(FormCollection unused)
        {
            return Content(String.Format("<p>" + DateTime.Now + "</p>"));
        }
    }
}
