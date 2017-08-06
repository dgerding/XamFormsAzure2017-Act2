using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(XamFormsWithAzure2017.MobileAppService.Startup))]

namespace XamFormsWithAzure2017.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}