using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreAngularApp2.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
