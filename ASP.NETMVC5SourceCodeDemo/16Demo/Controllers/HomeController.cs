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

        /// <summary>
        /// 与Redirect一样，但它返回一个把permanent属性设置为true的RedirectResult，因此，返回一个http 301状态码
        /// </summary>
        /// <returns></returns>
        public RedirectResult RedirectPermanent()
        {
           // return RedirectPermanent();
            return RedirectPermanent("TestRedirect");
        }
    }
}