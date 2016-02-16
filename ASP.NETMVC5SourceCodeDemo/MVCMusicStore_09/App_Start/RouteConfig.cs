using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCMusicStore_09
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // routes.MapMvcAttributeRoutes();//使用特性路由的时候 添加此语句
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "blog",
               url: "{year}/{month}/{day}",
               defaults: new { controller = "blog", action = "index" },
               constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            

           
        }
    }
}
