using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingMVC.Startup))]
namespace TestingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
