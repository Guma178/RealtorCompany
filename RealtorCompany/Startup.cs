using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealtorCompany.Startup))]
namespace RealtorCompany
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
