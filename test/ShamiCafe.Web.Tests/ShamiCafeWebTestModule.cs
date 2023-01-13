using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShamiCafe.EntityFrameworkCore;
using ShamiCafe.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ShamiCafe.Web.Tests
{
    [DependsOn(
        typeof(ShamiCafeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ShamiCafeWebTestModule : AbpModule
    {
        public ShamiCafeWebTestModule(ShamiCafeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ShamiCafeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ShamiCafeWebMvcModule).Assembly);
        }
    }
}