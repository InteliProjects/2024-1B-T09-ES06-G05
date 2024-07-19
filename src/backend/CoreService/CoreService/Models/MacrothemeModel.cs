using System.ComponentModel.DataAnnotations;

namespace CoreService.Models
{
    // Represents the MacroThemeModel class used for data transfer.
    public class MacroThemeModel
    {
        [Required]
        public string Name { get; set; }
    }
}
