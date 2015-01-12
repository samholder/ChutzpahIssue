using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChutzpaWeb.Startup))]
namespace ChutzpaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
