using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ASPNetCoreAngularApp2.Roles.Dto;
using ASPNetCoreAngularApp2.Users.Dto;

namespace ASPNetCoreAngularApp2.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
