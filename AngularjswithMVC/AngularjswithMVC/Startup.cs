using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularjswithMVC.Startup))]
namespace AngularjswithMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
