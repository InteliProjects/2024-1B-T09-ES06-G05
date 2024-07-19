using System.ComponentModel.DataAnnotations;

namespace CoreService.DTOs
{
	// Represents the SynergyDTO class used for data transfer.
	public class SynergyDTO
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string Status { get; set; }
		public int SourceProjectId { get; set; }
		public string SourceProjectName { get; set; }
		public string SourceUserName { get; set; }
		public string SourceUserEnterprise { get; set; }
		public string SourceMicrotheme { get; set; }
		public string SourceMacrotheme { get; set; }
		public int TargetProjectId { get; set; }
		public string TargetProjectName { get; set; }
		public string TargetUserName { get; set; }
		public string TargetUserEnterprise { get; set; }
		public string TargetMicrotheme { get; set; }
		public string TargetMacrotheme { get; set; }
	}
}
