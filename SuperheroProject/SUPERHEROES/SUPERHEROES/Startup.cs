using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SUPERHEROES.Startup))]
namespace SUPERHEROES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
