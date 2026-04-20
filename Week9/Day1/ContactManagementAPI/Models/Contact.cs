using System.ComponentModel.DataAnnotations;

namespace ContactManagement.API.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;
    }
}