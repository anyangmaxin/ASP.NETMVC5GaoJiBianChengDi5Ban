using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Owin;
[assembly: OwinStartupAttribute(typeof(MVCMusicStore_07.Startup))]
namespace MVCMusicStore_07
{
    
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            
        }
    }
}