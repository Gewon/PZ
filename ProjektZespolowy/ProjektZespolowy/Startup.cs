using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektZespolowy.Startup))]
namespace ProjektZespolowy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
