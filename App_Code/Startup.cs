using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mars.Startup))]
namespace mars
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
