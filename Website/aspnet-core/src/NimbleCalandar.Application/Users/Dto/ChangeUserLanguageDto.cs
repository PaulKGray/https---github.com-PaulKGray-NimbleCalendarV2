using System.ComponentModel.DataAnnotations;

namespace NimbleCalandar.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}