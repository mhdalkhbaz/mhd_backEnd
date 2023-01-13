using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShamiCafe.Authorization;

namespace ShamiCafe
{
    [DependsOn(
        typeof(ShamiCafeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ShamiCafeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ShamiCafeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ShamiCafeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
