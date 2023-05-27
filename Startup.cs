using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VirtualMuseum.Startup))]
namespace VirtualMuseum
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
