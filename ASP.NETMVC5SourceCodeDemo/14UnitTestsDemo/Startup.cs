using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_14UnitTestsDemo.Startup))]
namespace _14UnitTestsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
