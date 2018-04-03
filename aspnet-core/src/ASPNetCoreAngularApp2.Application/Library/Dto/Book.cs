using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Application.Services.Dto;

namespace ASPNetCoreAngularApp2.Library.Dto
{
    public class Book:EntityDto<long>
    {
        //[Key]
        //public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [ForeignKey("AuthorId")]
        public AuthorDto AuthorDto { get; set; }

        public Guid AuthorId { get; set; }
    }
}
