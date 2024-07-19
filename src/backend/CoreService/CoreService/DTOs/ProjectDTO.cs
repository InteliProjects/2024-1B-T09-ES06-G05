namespace CoreService.DTOs
{
    // Represents a data transfer object for a project.
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
        public string Enterprise { get; set; }
        public string Microtheme { get; set; }
        public string Macrotheme { get; set; }
    }
}