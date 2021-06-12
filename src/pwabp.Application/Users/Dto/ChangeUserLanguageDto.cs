using System.ComponentModel.DataAnnotations;

namespace pwabp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}