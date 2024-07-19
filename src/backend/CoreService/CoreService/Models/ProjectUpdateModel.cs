using System.ComponentModel.DataAnnotations;

namespace CoreService.Models
{
    // Represents the ProjectModel class used for data transfer.
    public class ProjectUpdateModel
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ShortDescription { get; set; }
        public required string Status { get; set; }
    }
}