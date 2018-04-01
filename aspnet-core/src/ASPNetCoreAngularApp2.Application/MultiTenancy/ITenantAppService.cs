using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ASPNetCoreAngularApp2.MultiTenancy.Dto;

namespace ASPNetCoreAngularApp2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
