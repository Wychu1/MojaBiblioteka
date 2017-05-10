using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MojaBiblioteka.Startup))]
namespace MojaBiblioteka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
