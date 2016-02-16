using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using MVCMusicStore_05.DbContext;

namespace MVCMusicStore_05
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new DbInitializer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
