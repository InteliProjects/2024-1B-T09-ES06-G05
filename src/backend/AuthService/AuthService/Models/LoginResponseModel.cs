using System.ComponentModel.DataAnnotations;

namespace AuthService.Models
{
    // Represents the response model for a login operation.
    public class LoginResponseModel
    {
        public string Token { get; set; }
        public int Id { get; set; }

    }
}