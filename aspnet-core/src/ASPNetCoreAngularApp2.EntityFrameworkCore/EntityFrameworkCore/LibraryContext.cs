
using ASPNetCoreAngularApp2.Library.Dto;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreAngularApp2.EntityFrameworkCore
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<AuthorDto> Authors { get; set; }
        public DbSet<BookDto> Books { get; set; }

    }
}