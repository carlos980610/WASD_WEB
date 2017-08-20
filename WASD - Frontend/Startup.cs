using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WASD___Frontend.Startup))]
namespace WASD___Frontend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
