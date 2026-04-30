using System.ComponentModel.DataAnnotations;

namespace ContactManagement.API.DTOs
{
    public class LoginDto
    {
        [Required, EmailAddress]
        public string EmailId { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
