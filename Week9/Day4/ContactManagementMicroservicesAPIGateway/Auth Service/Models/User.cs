namespace AuthService.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;  
        public string Role { get; set; } = "User";            //  Admin or User
    }
}
