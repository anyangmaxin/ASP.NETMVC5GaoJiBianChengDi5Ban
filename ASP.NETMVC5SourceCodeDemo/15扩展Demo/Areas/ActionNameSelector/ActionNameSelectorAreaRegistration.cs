using System.Web.Mvc;

namespace _15扩展Demo.Areas.ActionNameSelector
{
    public class ActionNameSelectorAreaRegistration : AreaRegistration
    {
        public override string AreaName { get { return "ActionNameSelector"; } }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ActionNameSelector_default",
                "ActionNameSelector/{action}/{id}",
                new { controller = "ActionName", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
