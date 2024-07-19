using CoreService.DTOs;
using CoreService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreService.Repositories
{
    // IMacroThemeRepository interface with methods to query the database 
    public interface IMacroThemeRepository
    {
        Task<IEnumerable<MacroThemeDTO>> GetAllMacroThemes();
        Task<IEnumerable<ProjectDTO>> GetProjectsByMacroThemeId(int macroThemeId);
        Task<IEnumerable<MicroThemeDTO>> GetMicroThemesByMacroThemeId(int macroThemeId);
    }
}
