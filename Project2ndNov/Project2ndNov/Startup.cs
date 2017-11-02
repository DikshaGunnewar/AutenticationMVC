using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project2ndNov.Startup))]
namespace Project2ndNov
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
