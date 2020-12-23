using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarDev.Startup))]
namespace StarDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
