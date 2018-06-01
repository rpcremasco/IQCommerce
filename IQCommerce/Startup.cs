using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IQCommerce.Startup))]
namespace IQCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
