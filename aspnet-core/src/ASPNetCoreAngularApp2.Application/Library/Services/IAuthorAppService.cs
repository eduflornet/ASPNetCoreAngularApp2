using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ASPNetCoreAngularApp2.Library.Dto;
using ASPNetCoreAngularApp2.Roles.Dto;

namespace ASPNetCoreAngularApp2.Library.Services
{
    public interface IAuthorAppService : IAsyncCrudAppService<AuthorDto, long, PagedResultRequestDto, AuthorForCreationDto, AuthorDto>
    {
        Task<ListResultDto<AuthorDto>> GetAuthors();
    }
}
