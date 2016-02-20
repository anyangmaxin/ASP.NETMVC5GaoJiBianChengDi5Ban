using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult TestRedirect()
        {
            return View();
           // return Redirect("Index");
        }

        /// <summary>
        /// 返回一个RedirectResult对象，把用户重定向到一个合适的url
        /// </summary>
        /// <returns></returns>
        public ActionResult Redirect()
        {
            return Redirect("TestRedirect");
            
        }
    }
}