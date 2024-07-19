using System.ComponentModel.DataAnnotations;

namespace CoreService.Models
{
    // Represents the UserModel class used for data transfer.
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Enterprise { get; set; }
        public string Position { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
