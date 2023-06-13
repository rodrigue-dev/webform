using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(b_school.Startup))]
namespace b_school
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
