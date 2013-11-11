using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RevionicsDemo.Startup))]
namespace RevionicsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
