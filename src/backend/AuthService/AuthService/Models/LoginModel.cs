using System.ComponentModel.DataAnnotations;

namespace AuthService.Models
{
    // Represents the login model used for authentication.
    public class LoginModel
    {

        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }
    }
}