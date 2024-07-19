using System.ComponentModel.DataAnnotations;

namespace CoreService.DTOs
{
    // Represents the UserDTO class used for data transfer.
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Enterprise { get; set; }
        public string Position { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
