using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyBusiness.Configuration;

namespace MyBusiness.Web.Host.Startup
{
    [DependsOn(
       typeof(MyBusinessWebCoreModule))]
    public class MyBusinessWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyBusinessWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyBusinessWebHostModule).GetAssembly());
        }
    }
}
