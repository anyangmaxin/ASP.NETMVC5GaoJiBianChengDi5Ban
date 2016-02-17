using System.Web.Mvc;
using _15扩展Demo.Areas.BasicAuthenticationFilter.Models;
using _15扩展Demo.Areas.BasicAuthenticationFilter.Utility;

namespace _15扩展Demo.Areas.BasicAuthenticationFilter.Controllers
{
    public class BasicAuthenticationFilterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [BasicAuthentication(Password = "secret")]
        [Authorize]
        public ActionResult Authenticated()
        {
            User model = new User { Name = User.Identity.Name };
            return View(model);
        }
    }
}