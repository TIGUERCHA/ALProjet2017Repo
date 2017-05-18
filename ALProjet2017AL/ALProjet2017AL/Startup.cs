using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALProjet2017AL.Startup))]
namespace ALProjet2017AL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
