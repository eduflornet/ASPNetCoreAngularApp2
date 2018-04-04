
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using ASPNetCoreAngularApp2.Library.Dto;
using ASPNetCoreAngularApp2.Library.Entities;
using AutoMapper;

namespace ASPNetCoreAngularApp2.Library.Services
{
    public class AuthorAppService : IAuthorAppService

    {
        private readonly IRepository<Author> _authorRepository;
        private readonly IObjectMapper _objectMapper;

        public AuthorAppService(IRepository<Author> authorRepository, IObjectMapper objectMapper)
        {
            _authorRepository = authorRepository;
            _objectMapper = objectMapper;
        }

        public Task<AuthorDto> Get(EntityDto<Guid> input)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<AuthorDto>> GetAll(PagedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDto> Create(AuthorForCreationDto input)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDto> Update(AuthorDto input)
        {
            throw new NotImplementedException();
        }

        public Task Delete(EntityDto<Guid> input)
        {
            throw new NotImplementedException();
        }

        public Task<ListResultDto<AuthorDto>> GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
