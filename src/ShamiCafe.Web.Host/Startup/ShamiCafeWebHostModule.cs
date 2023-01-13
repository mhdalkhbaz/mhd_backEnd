using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShamiCafe.Configuration;

namespace ShamiCafe.Web.Host.Startup
{
    [DependsOn(
       typeof(ShamiCafeWebCoreModule))]
    public class ShamiCafeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ShamiCafeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ShamiCafeWebHostModule).GetAssembly());
        }
    }
}
