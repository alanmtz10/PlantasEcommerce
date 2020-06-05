using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VentaPlantasEcommerce.Startup))]
namespace VentaPlantasEcommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
