using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace pwabp.Controllers
{
    public abstract class pwabpControllerBase: AbpController
    {
        protected pwabpControllerBase()
        {
            LocalizationSourceName = pwabpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
