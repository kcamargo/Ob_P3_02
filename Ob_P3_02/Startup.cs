using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ob_P3_02.Startup))]
namespace Ob_P3_02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
