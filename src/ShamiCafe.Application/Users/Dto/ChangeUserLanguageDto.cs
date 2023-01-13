using System.ComponentModel.DataAnnotations;

namespace ShamiCafe.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}