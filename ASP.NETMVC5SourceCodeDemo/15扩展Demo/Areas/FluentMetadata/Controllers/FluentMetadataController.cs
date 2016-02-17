using System.Web.Mvc;
using _15扩展Demo.Areas.FluentMetadata.Models;

namespace _15扩展Demo.Areas.FluentMetadata.Controllers
{
    public class FluentMetadataController : Controller
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
