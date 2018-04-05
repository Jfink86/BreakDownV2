using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BreakDownV2.Startup))]
namespace BreakDownV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
