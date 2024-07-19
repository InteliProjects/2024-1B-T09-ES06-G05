using Microsoft.AspNetCore.Authorization;
using CoreService.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreService.Models;
using CoreService.DTOs;
using CoreService.Utils;


namespace CoreService.Controllers
{
    // Specifies that this class is an API controller
    [ApiController]
    [Route("macrothemes")]
    [Authorize]

    public class MacroThemeController : ControllerBase
    {
        // Inject the macro theme repository
        private readonly IMacroThemeRepository _macroThemeRepository;

        // Constructor to initialize the macro theme controller
        public MacroThemeController(IMacroThemeRepository macroThemeRepository)
        {
            _macroThemeRepository = macroThemeRepository;
        }

        // Endpoint to get all macro themes
        [HttpGet]
        public async Task<IActionResult> GetAllMacroThemes()
        {
            // Call the repository method to get all macro themes
            var macroThemes = await _macroThemeRepository.GetAllMacroThemes();

            // Return the macro themes with a 200 OK response
            return Ok(macroThemes);
        }

        // Endpoint to get projects by macro theme ID
        [HttpGet("{id}/projects")]
        [REQ("REQ-04")]
        public async Task<IActionResult> GetProjectsByMacroThemeId(int id)
        {
            // Call the repository method to get projects by macro theme ID
            var projects = await _macroThemeRepository.GetProjectsByMacroThemeId(id);

            // Return the list of projects with a 200 OK response
            return Ok(projects);
        }

        // Endpoint to get micro themes by macro theme ID
        [HttpGet("{id}/microthemes")]
        public async Task<IActionResult> GetMicroThemesByMacroThemeId(int id)
        {
            // Call the repository method to get micro themes by macro theme ID
            var microThemes = await _macroThemeRepository.GetMicroThemesByMacroThemeId(id);

            // Return the list of micro themes with a 200 OK response
            return Ok(microThemes);
        }
    }
}
