using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.WebPages;

namespace _16Demo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //注册基于自定义准则的设备模式，例如针对WindowsPhone设备
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("WinPhone")
            {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf("Windes Phone OS", StringComparison.OrdinalIgnoreCase) >= 0)
            });
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
