using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(D08_EF6_MVC_CodeF.Startup))]
namespace D08_EF6_MVC_CodeF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}