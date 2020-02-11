using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 4, ErrorMessage = "You must specify password with at least 4 characters.")]
        public string Password { get; set; }
    }
}