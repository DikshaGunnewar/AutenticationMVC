using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailendingDemo.Startup))]
namespace EmailendingDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
