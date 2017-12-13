using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_SASS.Startup))]
namespace MVC_SASS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
