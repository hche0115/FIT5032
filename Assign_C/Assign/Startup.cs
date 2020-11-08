using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assign.Startup))]
namespace Assign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
