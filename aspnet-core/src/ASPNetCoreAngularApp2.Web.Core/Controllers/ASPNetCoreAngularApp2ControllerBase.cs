using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ASPNetCoreAngularApp2.Controllers
{
    public abstract class ASPNetCoreAngularApp2ControllerBase: AbpController
    {
        protected ASPNetCoreAngularApp2ControllerBase()
        {
            LocalizationSourceName = ASPNetCoreAngularApp2Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
