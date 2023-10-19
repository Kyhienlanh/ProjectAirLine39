using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectAirLine39.Startup))]
namespace ProjectAirLine39
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
