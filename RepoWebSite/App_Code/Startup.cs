using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepoWebSite.Startup))]
namespace RepoWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
