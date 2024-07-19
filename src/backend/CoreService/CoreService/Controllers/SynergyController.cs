using Microsoft.AspNetCore.Authorization;
using CoreService.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreService.Services;
using CoreService.Models;
using CoreService.DTOs;
using System.Security.Claims;
using CoreService.Utils;


namespace CoreService.Controllers
{
    // Specifies that this class is an API controller
    [ApiController]
    [Route("synergies")]
    [Authorize]

    public class SynergyController : ControllerBase
    {
        // Inject the synergy repository and mapper
        private readonly ISynergyRepository _synergyRepository;

        // Constructor to initialize the synergy controller
        public SynergyController(ISynergyRepository synergyRepository)
        {
            _synergyRepository = synergyRepository;
        }

        // Endpoint to create a synergy
        [HttpPost()]
        [REQ("REQ-07")]
        public async Task<IActionResult> CreateSynergy([FromBody] SynergyModel synergyModel)
        {
            // Call the repository method to check if a synergy with the same projects already exists
            var synergyExists = await _synergyRepository.SynergyExistsByProjectsIds(synergyModel.SourceProject, synergyModel.TargetProject);

            // Return a 400 Bad Request response if the synergy already exists
            if (synergyExists)
            {
                return BadRequest("Synergy already exists for these projects");
            }

            // Call the repository method to create the synergy
            var id = await _synergyRepository.CreateSynergy(synergyModel);

            // Return the new synergy ID with a 200 OK response
            return Ok(id);
        }

        // Endpoint to get a synergy by ID
        [HttpGet("{id}")]
        [REQ("REQ-09")]
        public async Task<IActionResult> GetSynergyById(int id)
        {
            // Call the repository method to get the synergy by ID
            var synergy = await _synergyRepository.GetSynergyById(id);

            // Return a 404 Not Found response if the synergy does not exist
            if (synergy == null)
            {
                return NotFound();
            }

            // Return the synergy with a 200 OK response
            return Ok(synergy);
        }

        // Endpoint to create an update for a synergy
        [HttpPost("{id}/updates")]
        public async Task<IActionResult> CreateSynergyUpdate(int id, [FromBody] SynergyUpdateModel synergyUpdateModel)
        {
            // Check if the synergy exists
            var synergyExists = await _synergyRepository.SynergyExistsBySynergyId(id);
            if (!synergyExists)
            {
                // Return a 400 Bad Request response if the synergy does not exist
                return BadRequest("Synergy ID does not exist");
            }

            // Call the repository method to create a synergy update and get the new update ID
            var result = await _synergyRepository.CreateSynergyUpdate(id, synergyUpdateModel);

            // Return a 400 Bad Request response if the update ID is null
            if (result == null)
            {
                return BadRequest("Failed to create synergy update");
            }

            // Return the new update ID with a 200 OK response
            return Ok(result);
        }

        [HttpGet("{id}/updates")]
        public async Task<IActionResult> GetUpdatesBySynergyId(int id)
        {
            var updates = await _synergyRepository.GetUpdatesBySynergyId(id);

            return Ok(updates);
        }

    }

}