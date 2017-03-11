using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DRAOSApplication.Startup))]
namespace DRAOSApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
