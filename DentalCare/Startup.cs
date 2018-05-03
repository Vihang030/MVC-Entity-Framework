using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentalCare.Startup))]
namespace DentalCare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
