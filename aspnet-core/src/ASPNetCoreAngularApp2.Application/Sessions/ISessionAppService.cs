using System.Threading.Tasks;
using Abp.Application.Services;
using ASPNetCoreAngularApp2.Sessions.Dto;

namespace ASPNetCoreAngularApp2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
