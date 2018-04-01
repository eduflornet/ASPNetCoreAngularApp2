using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ASPNetCoreAngularApp2.Configuration.Dto;

namespace ASPNetCoreAngularApp2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ASPNetCoreAngularApp2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
