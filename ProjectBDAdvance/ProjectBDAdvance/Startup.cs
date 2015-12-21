using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectBDAdvance.Startup))]
namespace ProjectBDAdvance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
