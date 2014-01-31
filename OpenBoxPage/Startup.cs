using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenBoxPage.Startup))]
namespace OpenBoxPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
