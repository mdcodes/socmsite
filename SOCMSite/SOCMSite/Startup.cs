using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOCMSite.Startup))]
namespace SOCMSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
