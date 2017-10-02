using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autos4Sale.Web.Startup))]
namespace Autos4Sale.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
