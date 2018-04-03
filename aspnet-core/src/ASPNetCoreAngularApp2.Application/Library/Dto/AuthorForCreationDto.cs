using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNetCoreAngularApp2.Library.Dto
{
    public class AuthorForCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Genre { get; set; }

        public ICollection<BookForCreationDto> Books { get; set; }
            = new List<BookForCreationDto>();
    }
}
