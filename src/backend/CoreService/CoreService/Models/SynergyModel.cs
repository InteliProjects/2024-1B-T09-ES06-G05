using System.ComponentModel.DataAnnotations;

namespace CoreService.Models
{
    // Represents the SynergyModel class used for data transfer.
    public class SynergyModel
    {
        public int SourceProject {  get; set; }
        public int TargetProject { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

    }
}