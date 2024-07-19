using System.ComponentModel.DataAnnotations;

namespace CoreService.DTOs
{
    // Represents the ProjectSynergyDTO class used for data transfer.
    public class ProjectSynergyDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string UserName { get; set; }
        public string UserEnterprise { get; set; }
        public string Microtheme { get; set; }
        public string Macrotheme { get; set; }
    }
}
