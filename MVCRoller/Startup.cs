using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRoller.Startup))]
namespace MVCRoller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
