using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TfsHistory.Startup))]
namespace TfsHistory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
