using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComCon_Redesign.Startup))]
namespace ComCon_Redesign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
