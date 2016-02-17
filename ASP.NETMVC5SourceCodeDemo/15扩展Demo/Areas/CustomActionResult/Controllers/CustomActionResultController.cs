using System.Web.Mvc;
using _15扩展Demo.Areas.CustomActionResult.Models;
using _15扩展Demo.Areas.CustomActionResult.Utility;

namespace _15扩展Demo.Areas.CustomActionResult.Controllers
{
    public class CustomActionResultController : Controller
    {
        public ActionResult Index()
        {
            var model = new Person
            {
                FirstName = "Brad",
                LastName = "Wilson",
                Blog = "http://bradwilson.typepad.com"
            };

            return new XmlResult(model);
        }
    }
}
