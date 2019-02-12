using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hiwarcom.Web.Startup))]
namespace Hiwarcom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
