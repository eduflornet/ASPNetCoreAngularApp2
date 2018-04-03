using System;
using System.Collections.Generic;
using ASPNetCoreAngularApp2.Helpers;
using ASPNetCoreAngularApp2.Library.Dto;


namespace ASPNetCoreAngularApp2.Library.Services
{
    public interface ILibraryRepository
    {
        PagedList<AuthorDto> GetAuthors(AuthorsResourceParameters authorsResourceParameters);
        AuthorDto GetAuthor(Guid authorId);
        IEnumerable<AuthorDto> GetAuthors(IEnumerable<Guid> authorIds);
        void AddAuthor(AuthorDto authorDto);
        void DeleteAuthor(AuthorDto authorDto);
        void UpdateAuthor(AuthorDto authorDto);
        bool AuthorExists(Guid authorId);
        IEnumerable<Book> GetBooksForAuthor(Guid authorId);
        Book GetBookForAuthor(Guid authorId, Guid bookId);
        void AddBookForAuthor(Guid authorId, Book book);
        void UpdateBookForAuthor(Book book);
        void DeleteBook(Book book);
        bool Save();
    }
}
