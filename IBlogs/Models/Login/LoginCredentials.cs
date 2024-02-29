namespace IBlogs.Models.Login
{
    public class LoginCredentials
    {
        public int LoginID { get; set; } 
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;    
    }
}
