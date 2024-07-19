using System.ComponentModel.DataAnnotations;

namespace CoreService.Models
{
    // Represents the UserLoginModel class used for data transfer.
    public class UserLoginModel
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}