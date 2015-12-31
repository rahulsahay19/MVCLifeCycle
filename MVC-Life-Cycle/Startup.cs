using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Life_Cycle.Startup))]
namespace MVC_Life_Cycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
