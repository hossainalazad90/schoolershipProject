using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScholershipManagement.Startup))]
namespace ScholershipManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
