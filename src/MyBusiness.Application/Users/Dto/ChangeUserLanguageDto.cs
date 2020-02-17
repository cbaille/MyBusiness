using System.ComponentModel.DataAnnotations;

namespace MyBusiness.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}