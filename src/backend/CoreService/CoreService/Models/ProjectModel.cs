using System.ComponentModel.DataAnnotations;

namespace CoreService.Models
{
    // Represents the ProjectModel class used for data transfer.
    public class ProjectModel
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ShortDescription {get; set; }
        public required string Status { get; set; }
        public required int UserId { get; set; }
        public required int MicrothemeId { get; set; }
    }
}