using System.ComponentModel.DataAnnotations;

namespace ContactManagement.API.Models
{
    public class UserInfo
    {
        [Key]
        [EmailAddress]
        public string EmailId { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Role { get; set; } = string.Empty; // Admin / User
    }
}