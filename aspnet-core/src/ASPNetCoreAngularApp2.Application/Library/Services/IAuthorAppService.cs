using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ASPNetCoreAngularApp2.Library.Dto;


namespace ASPNetCoreAngularApp2.Library.Services
{
    public interface IAuthorAppService : IApplicationService
    {
        Task<ListResultDto<AuthorDto>> GetAuthors();
    }
}
