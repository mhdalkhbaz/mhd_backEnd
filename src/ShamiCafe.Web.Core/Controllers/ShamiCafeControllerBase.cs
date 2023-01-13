using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ShamiCafe.Controllers
{
    public abstract class ShamiCafeControllerBase: AbpController
    {
        protected ShamiCafeControllerBase()
        {
            LocalizationSourceName = ShamiCafeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
