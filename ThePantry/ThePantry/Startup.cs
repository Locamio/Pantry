using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThePantry.Startup))]
namespace ThePantry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
