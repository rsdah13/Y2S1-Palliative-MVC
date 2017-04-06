using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Palliative.Startup))]
namespace Palliative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
