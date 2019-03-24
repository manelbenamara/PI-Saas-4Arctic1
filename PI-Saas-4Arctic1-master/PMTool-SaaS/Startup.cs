using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMTool_SaaS.Startup))]
namespace PMTool_SaaS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
