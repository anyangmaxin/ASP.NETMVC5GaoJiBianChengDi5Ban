using System.Web.Mvc;
using _15扩展Demo.Areas.FluentValidation.Models;

namespace _15扩展Demo.Areas.FluentValidation.Controllers
{
    public class FluentValidationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            return View(contact);
        }
    }
}
