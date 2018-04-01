using System.Threading.Tasks;
using Abp.Application.Services;
using ASPNetCoreAngularApp2.Authorization.Accounts.Dto;

namespace ASPNetCoreAngularApp2.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
