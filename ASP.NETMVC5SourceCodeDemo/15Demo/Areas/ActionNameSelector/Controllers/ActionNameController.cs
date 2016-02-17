using System.Web.Mvc;
using _15Demo.Areas.ActionNameSelector.Utility;

namespace _15Demo.Areas.ActionNameSelector.Controllers
{
    public class ActionNameController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Product]
        public ActionResult Product(int productId)
        {
            return Content("You asked for product #" + productId);
        }
    }
}
