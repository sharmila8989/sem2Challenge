using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trackModulesAPI.Startup))]
namespace trackModulesAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
