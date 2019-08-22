using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P_000703.Web.Startup))]
namespace P_000703.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
