using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace _15Demo.Areas.TimingFilter.Utility
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ExecutionTimingAttribute : ActionFilterAttribute
    {
        IStatefulStorage storage = StatefulStorage.PerRequest;

        private string actionSort = "";

        Stopwatch GetStopwatch(string name)
        {
            return storage.GetOrAdd<Stopwatch>(name, () => new Stopwatch());
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            GetStopwatch("action").Start();
            actionSort += "[OnActionExecuting]";
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            GetStopwatch("action").Stop();
            actionSort += "[OnActionExecuted]";
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            GetStopwatch("result").Start();
            actionSort += "[OnResultExecuting]";
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var resultStopwatch = GetStopwatch("result");
            resultStopwatch.Stop();
            actionSort += "[OnResultExecuted]";
            var actionStopwatch = GetStopwatch("action");
            var response = filterContext.HttpContext.Response;

            if (!filterContext.IsChildAction && response.ContentType == "text/html")
                response.Write(
                    String.Format(
                        "<h5>Action '{0} :: {1}', Execute: {2}ms, Result: {3}ms.</h5> \r Ö´ÐÐË³Ðò£º{4}",
                        filterContext.RouteData.Values["controller"],
                        filterContext.RouteData.Values["action"],
                        actionStopwatch.ElapsedMilliseconds,
                        resultStopwatch.ElapsedMilliseconds,
                        actionSort
                    )
                );
        }
    }
}