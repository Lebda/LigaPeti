using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LigaPetiWeb.App_Start.Startup))]
namespace LigaPetiWeb.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
