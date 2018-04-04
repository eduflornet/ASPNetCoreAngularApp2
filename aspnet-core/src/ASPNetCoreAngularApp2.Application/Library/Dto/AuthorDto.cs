﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace ASPNetCoreAngularApp2.Library.Dto
{
    public class AuthorDto:EntityDto<Guid>
    {
        //[Key]
        //public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        public DateTimeOffset? DateOfDeath { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        public ICollection<BookDto> Books { get; set; }
            = new List<BookDto>();
    }
}
