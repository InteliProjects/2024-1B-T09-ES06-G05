using System.ComponentModel.DataAnnotations;

namespace CoreService.Models
{
    // Represents the RatingModel class used for data transfer.
    public class RatingModel
    {
        [Required]
        public int Rating { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
