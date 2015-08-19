using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVALearnAsp4._5MVC.Startup))]
namespace MVALearnAsp4._5MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
