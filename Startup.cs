using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(silkroadAcc.Startup))]
namespace silkroadAcc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
