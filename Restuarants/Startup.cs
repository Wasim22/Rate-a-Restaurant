using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restuarants.Startup))]
namespace Restuarants
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
