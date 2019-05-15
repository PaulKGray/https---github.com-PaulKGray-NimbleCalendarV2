using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NimbleCalandar.Controllers
{
    public abstract class NimbleCalandarControllerBase: AbpController
    {
        protected NimbleCalandarControllerBase()
        {
            LocalizationSourceName = NimbleCalandarConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
