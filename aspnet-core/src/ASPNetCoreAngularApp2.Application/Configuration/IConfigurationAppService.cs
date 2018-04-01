using System.Threading.Tasks;
using ASPNetCoreAngularApp2.Configuration.Dto;

namespace ASPNetCoreAngularApp2.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
