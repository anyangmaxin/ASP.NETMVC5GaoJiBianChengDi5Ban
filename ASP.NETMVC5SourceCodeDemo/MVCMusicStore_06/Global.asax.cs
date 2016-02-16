using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using MVCMusicStore_06.DbContext;

namespace MVCMusicStore_06
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
