using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcRMS.Startup))]
namespace mvcRMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
