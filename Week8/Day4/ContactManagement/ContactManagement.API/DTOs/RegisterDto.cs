using System.ComponentModel.DataAnnotations;

namespace ContactManagement.API.DTOs
{
    public class RegisterDto
    {
        [Required, EmailAddress]
        public string EmailId { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Role { get; set; } = string.Empty;
    }
}
