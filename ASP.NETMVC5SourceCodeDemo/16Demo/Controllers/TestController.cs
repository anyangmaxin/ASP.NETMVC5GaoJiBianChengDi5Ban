using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace _16Demo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public async Task<ActionResult> Index()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            stopwatch.Start();
            var geta = GetA();
            var getb = GetB();
            stopwatch.Stop();
            ViewBag.CountTimes = stopwatch.ElapsedMilliseconds + "|" + stopwatch.Elapsed + "|" + stopwatch.ElapsedTicks;
            ViewBag.GetA = geta;
            ViewBag.GetB = getb;

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Reset();
            stopwatch2.Start();
            var geta2 = GetA();
            var getb2 = GetB();
            await Task.WhenAll(geta2, getb2);
            stopwatch2.Stop();
            ViewBag.CountTimes2 = stopwatch2.ElapsedMilliseconds + "|" + stopwatch2.Elapsed + "|" + stopwatch2.ElapsedTicks;
            ViewBag.GetA2 = geta2;
            ViewBag.GetB2 = getb2;
            return View();
        }


        public static async Task<int> GetA()
        {
            Thread.Sleep(400);
            return 2;
        }


        public static async Task<double> GetB()
        {
            Thread.Sleep(800);
            return 2.3;
        }



    }
}