using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crm.Startup))]
namespace crm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
