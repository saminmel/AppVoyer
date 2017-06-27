using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppVeyor.Web.Startup))]
namespace AppVeyor.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
