using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoAEJ.Startup))]
namespace VideoAEJ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
