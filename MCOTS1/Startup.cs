using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCOTS1.Startup))]
namespace MCOTS1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
