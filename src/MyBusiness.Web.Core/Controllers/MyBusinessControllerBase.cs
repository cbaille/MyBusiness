using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyBusiness.Controllers
{
    public abstract class MyBusinessControllerBase: AbpController
    {
        protected MyBusinessControllerBase()
        {
            LocalizationSourceName = MyBusinessConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
