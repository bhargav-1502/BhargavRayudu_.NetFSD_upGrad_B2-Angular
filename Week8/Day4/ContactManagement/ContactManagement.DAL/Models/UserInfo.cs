namespace ContactManagement.DAL.Models
{
    public class UserInfo
    {
        public int UserInfoId { get; set; }
        public string EmailId { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
