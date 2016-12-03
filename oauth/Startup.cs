using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(oauth.Startup))]
namespace oauth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
