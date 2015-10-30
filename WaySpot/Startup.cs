using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WaySpot.Startup))]
namespace WaySpot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
