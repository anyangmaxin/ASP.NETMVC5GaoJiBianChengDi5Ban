using System.Threading;
using System.Web.Mvc;
using _15Demo.Areas.TimingFilter.Utility;

namespace _15Demo.Areas.TimingFilter.Controllers
{
    public class TimingFilterController : Controller
    {
        [ExecutionTiming]
        public ActionResult Index()
        {
            Thread.Sleep(100);
            return View();
        }
    }
}
