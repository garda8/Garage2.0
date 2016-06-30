using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Garage2._0Erik.Startup))]
namespace Garage2._0Erik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
