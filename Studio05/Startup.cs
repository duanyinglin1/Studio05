using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Studio05.Startup))]
namespace Studio05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
