using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CoreService.Repositories;
using CoreService.Services;
using CoreService.Models;
using CoreService.DTOs;
using CoreService.Utils;
using System.Security.Claims;

namespace CoreService.Controllers
{
    // Specifies that this class is an API controller
    [ApiController]
    [Route("projects")]
    [Authorize]
    public class ProjectController : ControllerBase
    {
        // Inject the project repository and OpenAI service
        private readonly IProjectRepository _projectRepository;
        private readonly IOpenAIService _openAIService;

        // Constructor to initialize the project repository
        public ProjectController(IProjectRepository projectRepository, IOpenAIService openAIService)
        {
            _projectRepository = projectRepository;
            _openAIService = openAIService;
        }

        // Endpoint to get ratings for a project and user
        [HttpGet("{projectId}/users/{userId}/ratings")]
        public async Task<IActionResult> GetRatingByProjectAndUser(int projectId, int userId)
        {
            var rating = await _projectRepository.GetRatingByProjectAndUser(projectId, userId);

            if (rating == null)
            {
                return NotFound();
            }

            return Ok(rating);
        }

        // Endpoint to get recommended projects by user ID
        [HttpGet("users/{id}/recommendations")]
        [REQ("REQ-03")]
        public async Task<IActionResult> GetRecommendedProjects(int id)
        {
            // Call the repository method to get recommended projects by user ID
            var projects = await _projectRepository.GetRecommendedProjects(id);

            // Return the list of recommended projects with a 200 OK response
            return Ok(projects);
        }

        // Endpoint to get a project by ID
        [HttpGet("{id}")]
        [REQ("REQ-05")]
        public async Task<IActionResult> GetProject(int id)
        {
            // Call the repository method to get the project by ID
            var project = await _projectRepository.GetProjectById(id);

            // Return a 404 Not Found response if the project does not exist
            if (project == null)
            {
                return NotFound();
            }

            // Return the project with a 200 OK response
            return Ok(project);
        }

        // Endpoint to create a project
        [HttpPost]
        [REQ("REQ-02")]
        public async Task<IActionResult> CreateProject(ProjectModel projectModel)
        {
            // Call the repository method to create the project
            var projectId = await _projectRepository.CreateProject(projectModel);

            // Badrequest if project id is null
            if (projectId == null)
            {
                return BadRequest();
            }

            // Return the new project ID with a 200 OK response
            return Ok(projectId);
        }

        // Endpoint to update a project
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(int id, [FromBody] ProjectUpdateModel projectUpdateModel)
        {
            // Checks if the project exists
            var projectExists = await _projectRepository.ProjectExists(id);

            // Return a 400 Bad Request response if the project does not exist
            if (projectExists == false)
            {
                return BadRequest("Project ID does not exist");
            }

            // Call the repository method to update the project
            var project = await _projectRepository.UpdateProject(id, projectUpdateModel);

            // Return a 200 OK response with the updated project
            return Ok();
        }

        // Endpoint to get all synergies for a project
        [HttpGet("{id}/synergies")]
        [REQ("REQ-09")]
        public async Task<IActionResult> GetSynergiesByProjectId(int id)
        {
            // Call the repository method to get synergies by project ID
            var synergies = await _projectRepository.GetSynergiesByProjectId(id);

            // Return the synergies with a 200 OK response
            return Ok(synergies);
        }

        // Endpoint to generate a project description using OpenAI
        [HttpPost("generate-description")]
        public async Task<IActionResult> GenerateProjectDescription([FromBody] ProjectDescriptionRequestModel requestModel)
        {
            // Call the OpenAI service to generate a project description
            var description = await _openAIService.GenerateProjectDescription(requestModel.ProjectName, requestModel.ProjectDetails);
            
            // Return the generated description with a 200 OK response
            return Ok(description);
        }

        // Endpoint to add a rating to a project
        [HttpPost("{id}/ratings")]
        [REQ("REQ-06")]
        public async Task<IActionResult> AddRatingToProject(int id, [FromBody] RatingModel ratingModel)
        {
            // Call the repository method to add a rating to the project
            var ratingId = await _projectRepository.AddRatingToProject(id, ratingModel);

            // Return a 400 Bad Request response if the rating ID is null
            if (ratingId == null)
            {
                return BadRequest("Failed to add rating to project");
            }

            // Return the new rating ID with a 200 OK response
            return Ok(ratingId);
        }

        // Enddpoint to delete a project
        [HttpDelete("{id}")]
        [REQ("REQ-02")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            // Check if the project exists
            var projectExists = await _projectRepository.ProjectExists(id);

            // Return a 400 Bad Request response if the project does not exist
            if (projectExists == false)
            {
                return BadRequest("Project ID does not exist");
            }

            // Call the repository method to delete the project
            await _projectRepository.DeleteProject(id);

            // Return a 200 OK response
            return Ok();
        }


        [HttpGet("users/{id}")]
        public async Task<IActionResult> GetProjectsByUserId(int id)
        {
            var projects = await _projectRepository.GetProjectsByUserId(id);
            
            return Ok(projects);
        }
    }
}
