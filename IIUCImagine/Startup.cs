using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IIUCImagine.Startup))]
namespace IIUCImagine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
