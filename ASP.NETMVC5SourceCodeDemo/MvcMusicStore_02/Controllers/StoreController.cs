using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore_02.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
            //return View();
        }

        /// <summary>
        /// store/Browse?genre=disco
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse,Genre=" + genre);
            return message;
        }

        /// <summary>
        /// Store/Details/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Details(int id)
        {
            string message = "Store.Details,ID=" + id;
            return message;
        }
    }
}