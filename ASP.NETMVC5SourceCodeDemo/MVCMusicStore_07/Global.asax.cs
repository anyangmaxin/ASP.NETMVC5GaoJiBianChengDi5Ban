using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using MVCMusicStore_07.DbContext;

namespace MVCMusicStore_07
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
