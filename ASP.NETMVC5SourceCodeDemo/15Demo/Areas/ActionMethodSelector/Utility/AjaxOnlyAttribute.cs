using System.Reflection;
using System.Web.Mvc;

namespace _15Demo.Areas.ActionMethodSelector.Utility
{
    public class AjaxOnlyAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext,
                                               MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.IsAjaxRequest();
        }
    }
}
