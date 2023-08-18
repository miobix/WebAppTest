using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp53w5.Startup))]
namespace WebApp53w5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
