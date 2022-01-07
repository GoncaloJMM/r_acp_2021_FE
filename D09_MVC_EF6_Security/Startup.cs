using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(D09_MVC_EF6_Security.Startup))]
namespace D09_MVC_EF6_Security
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
