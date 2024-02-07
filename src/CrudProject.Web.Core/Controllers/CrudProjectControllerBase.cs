using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CrudProject.Controllers
{
    public abstract class CrudProjectControllerBase: AbpController
    {
        protected CrudProjectControllerBase()
        {
            LocalizationSourceName = CrudProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
