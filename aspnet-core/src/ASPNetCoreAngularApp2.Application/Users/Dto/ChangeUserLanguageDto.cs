using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreAngularApp2.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}