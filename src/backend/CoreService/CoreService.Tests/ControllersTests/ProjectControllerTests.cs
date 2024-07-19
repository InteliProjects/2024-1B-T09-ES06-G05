using Xunit;
using CoreService.Controllers;
using CoreService.Models;
using CoreService.DTOs;
using CoreService.Repositories;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using CoreService.Services;

namespace CoreService.Tests.ControllersTests
{
    // Represents a test class for the ProjectController class.
    public class ProjectControllerTests
    {
        private readonly Mock<IProjectRepository> _mockProjectRepository;
        private readonly Mock<IOpenAIService> _mockOpenAIService;
        private readonly ProjectController _projectController;

        public ProjectControllerTests()
        {
            _mockProjectRepository = new Mock<IProjectRepository>();
            _mockOpenAIService = new Mock<IOpenAIService>();
            _projectController = new ProjectController(_mockProjectRepository.Object, _mockOpenAIService.Object);
        }

        // Test to verify the recommended projects
        [Fact]
        public async Task GetRecommendedProjects_ReturnsRecommendedProjects()
        {
            // Arrange
            var userId = 1;
            var expectedProjects = new List<ProjectDTO>
            {
                new ProjectDTO { Id = 1, Name = "Project 1", Description = "Description 1", ShortDescription = "Short Desc 1", Status = "Status 1" },
                new ProjectDTO { Id = 2, Name = "Project 2", Description = "Description 2", ShortDescription = "Short Desc 2", Status = "Status 2" }
            };
            _mockProjectRepository.Setup(x => x.GetRecommendedProjects(userId)).ReturnsAsync(expectedProjects);

            // Act
            var result = await _projectController.GetRecommendedProjects(userId);

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var projects = Assert.IsAssignableFrom<IEnumerable<ProjectDTO>>(actionResult.Value);
            Assert.Equal(expectedProjects.Count, projects.Count());

            // Verifica se cada projeto retornado tem os campos esperados
            foreach (var expectedProject in expectedProjects)
            {
                var matchingProject = projects.FirstOrDefault(p => p.Id == expectedProject.Id);
                Assert.NotNull(matchingProject);
                Assert.Equal(expectedProject.Name, matchingProject.Name);
                Assert.Equal(expectedProject.Description, matchingProject.Description);
                Assert.Equal(expectedProject.ShortDescription, matchingProject.ShortDescription);
                Assert.Equal(expectedProject.Status, matchingProject.Status);
            }
        }

        [Fact]
        public async Task CreateProject_ReturnsOk_WhenProjectIdIsNotNull()
        {
            // Arrange
            var projectModel = new ProjectModel
            {
                Name = "Test Project",
                Description = "Test Description",
                ShortDescription = "Test Short Description",
                Status = "Test Status",
                UserId = 1,
                MicrothemeId = 1
            };

            var projectId = 1;
            _mockProjectRepository.Setup(repo => repo.CreateProject(projectModel)).ReturnsAsync(projectId);

            // Act
            var result = await _projectController.CreateProject(projectModel);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(projectId, okResult.Value);
        }

        [Fact]
        public async Task CreateProject_ReturnsBadRequest_WhenProjectIdIsNull()
        {
            // Arrange
            var projectModel = new ProjectModel
            {
                Name = "Test Project",
                Description = "Test Description",
                ShortDescription = "Test Short Description",
                Status = "Test Status",
                UserId = 1,
                MicrothemeId = 1
            };
            _mockProjectRepository.Setup(repo => repo.CreateProject(projectModel)).ReturnsAsync((int?)null);

            // Act
            var result = await _projectController.CreateProject(projectModel);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetProject_IfProjectExists_ReturnsProject()
        {
            // Arrange
            var projectId = 1;
            var expectedProject = new ProjectDTO { Id = 1, Name = "Project 1", Description = "Description 1" };
            _mockProjectRepository.Setup(x => x.GetProjectById(projectId)).ReturnsAsync(expectedProject);

            // Act
            var result = await _projectController.GetProject(projectId);

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var project = Assert.IsType<ProjectDTO>(actionResult.Value);
            Assert.Equal(expectedProject.Id, project.Id);
            Assert.Equal(expectedProject.Name, project.Name);
            Assert.Equal(expectedProject.Description, project.Description);
            Assert.Equal(expectedProject.ShortDescription, project.ShortDescription);
            Assert.Equal(expectedProject.Status, project.Status);
        }

        [Fact]
        public async Task GetProject_IfProjectDoesNotExist_ReturnsNotFound()
        {
            // Arrange
            var projectId = 999;
            ProjectDTO nullProject = null;
            _mockProjectRepository.Setup(x => x.GetProjectById(projectId)).ReturnsAsync(nullProject);

            // Act
            var result = await _projectController.GetProject(projectId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetSynergiesByProjectId_WhenProjectIdValid_ReturnsSynergies()
        {
            // Arrange
            var projectId = 1;
            var expectedSynergies = new List<ProjectSynergyDTO>
            {
                new ProjectSynergyDTO
        {
            Id = 1,
            Type = "Type 1",
            Status = "Status 1",
            ProjectId = 2,
            ProjectName = "Project 2",
            UserName = "User 1",
            UserEnterprise = "Enterprise 1",
            Microtheme = "Microtheme 1",
            Macrotheme = "Macrotheme 1"
        },
        new ProjectSynergyDTO
        {
            Id = 2,
            Type = "Type 2",
            Status = "Status 2",
            ProjectId = 3,
            ProjectName = "Project 3",
            UserName = "User 2",
            UserEnterprise = "Enterprise 2",
            Microtheme = "Microtheme 2",
            Macrotheme = "Macrotheme 2"
        }
            };
            _mockProjectRepository.Setup(x => x.GetSynergiesByProjectId(projectId)).ReturnsAsync(expectedSynergies);

            // Act
            var result = await _projectController.GetSynergiesByProjectId(projectId);

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var synergies = Assert.IsAssignableFrom<IEnumerable<ProjectSynergyDTO>>(actionResult.Value);
            Assert.Equal(expectedSynergies.Count, synergies.Count());
        }

        [Fact]
        public async Task GetSynergiesByProjectId_WhenProjectIdInvalid_ReturnsEmptyArray()
        {
            // Arrange
            var projectId = 999;
            IEnumerable<ProjectSynergyDTO> emptyList = new List<ProjectSynergyDTO>();
            _mockProjectRepository.Setup(x => x.GetSynergiesByProjectId(projectId)).ReturnsAsync(emptyList);

            // Act
            var result = await _projectController.GetSynergiesByProjectId(projectId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsAssignableFrom<IEnumerable<ProjectSynergyDTO>>(okResult.Value);
            Assert.Empty(returnValue);
        }

        //Test to verify the project update
        [Fact]
        public async Task UpdateProject_WhenUpdateValid_ReturnsProjectId()
        {
            // Arrange
            var projectId = 1;
            var projectUpdateModel = new ProjectUpdateModel
            {
                Name = "Updated Project Name",
                Description = "Updated Description",
                ShortDescription = "Updated Short Description", 
                Status = "Active"
            };

            _mockProjectRepository.Setup(x => x.ProjectExists(projectId)).ReturnsAsync(true);
            _mockProjectRepository.Setup(x => x.UpdateProject(projectId, projectUpdateModel)).ReturnsAsync(true);

            // Act
            var result = await _projectController.UpdateProject(projectId, projectUpdateModel);

            // Assert
            var actionResult = Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task UpdateProject_WhenProjectDoesNotExist_ReturnsBadRequest()
        {
            // Arrange
            var projectId = 1;
            var projectUpdateModel = new ProjectUpdateModel
            {
                Name = "Updated Project Name",
                Description = "Updated Description",
                ShortDescription = "Updated Short Description",
                Status = "Active"
            };

            _mockProjectRepository.Setup(x => x.ProjectExists(projectId)).ReturnsAsync(false);

            // Act
            var result = await _projectController.UpdateProject(projectId, projectUpdateModel);

            // Assert
            var actionResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Project ID does not exist", actionResult.Value);
        }

        [Fact]
        public async Task GenerateDescription_ReturnsDescription_WhenDescriptionGenerated()
        {
            // Arrange
            var projectDescriptionRequestModel = new ProjectDescriptionRequestModel
            {
                ProjectName = "Test Project Name",
                ProjectDetails = "Test Project Details"
            };
            var expectedDescription = "This is a test project description generated by OpenAI.";

            _mockOpenAIService.Setup(x => x.GenerateProjectDescription(projectDescriptionRequestModel.ProjectName, projectDescriptionRequestModel.ProjectDetails)).ReturnsAsync(expectedDescription);

            // Act
            var result = await _projectController.GenerateProjectDescription(projectDescriptionRequestModel);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var description = Assert.IsType<string>(okResult.Value);
            Assert.Equal(expectedDescription, description);
        }   

        [Fact]
        public async Task AddRatingToProject_ReturnsOk_WhenRatingIsCreated()
        {
            // Arrange
            var projectId = 1;
            var ratingModel = new RatingModel
            {
                Rating = 5,
                UserId = 1
            };
            var expectedRatingId = 1;

            _mockProjectRepository.Setup(repo => repo.AddRatingToProject(projectId, ratingModel)).ReturnsAsync(expectedRatingId);

            // Act
            var result = await _projectController.AddRatingToProject(projectId, ratingModel);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(expectedRatingId, okResult.Value);
        }

        [Fact]
        public async Task AddRatingToProject_ReturnsBadRequest_WhenRatingCreationFails()
        {
            // Arrange
            var projectId = 1;
            var ratingModel = new RatingModel
            {
                Rating = 5,
                UserId = 1
            };

            _mockProjectRepository.Setup(repo => repo.AddRatingToProject(projectId, ratingModel)).ReturnsAsync((int?)null);

            // Act
            var result = await _projectController.AddRatingToProject(projectId, ratingModel);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        //Test to verify the project deletion
        [Fact]
        public async Task DeleteProject_WhenProjectExists_ReturnsOk()
        {
            // Arrange
            var projectId = 1;

            _mockProjectRepository.Setup(x => x.ProjectExists(projectId)).ReturnsAsync(true);

            // Act
            var result = await _projectController.DeleteProject(projectId);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        //Test to verify bad request when project does not exist while deleting
        [Fact]
        public async Task DeleteProject_WhenProjectDoesNotExist_ReturnsBadRequest()
        {
            // Arrange
            var projectId = 1;
            _mockProjectRepository.Setup(x => x.DeleteProject(projectId)).ReturnsAsync(false);

            // Act
            var result = await _projectController.DeleteProject(projectId);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task GetRatingByProjectAndUser_ReturnsOkResult_WhenRatingExists()
        {
            // Arrange
            var projectId = 1;
            var userId = 1;
            var expectedRating = new RatingDTO
            {
                Id = 1,
                Rating = 5
            };

            _mockProjectRepository.Setup(repo => repo.GetRatingByProjectAndUser(projectId, userId))
                .ReturnsAsync(expectedRating);

            // Act
            var result = await _projectController.GetRatingByProjectAndUser(projectId, userId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedRating = Assert.IsType<RatingDTO>(okResult.Value);
            Assert.Equal(expectedRating.Id, returnedRating.Id);
            Assert.Equal(expectedRating.Rating, returnedRating.Rating);
        }

        [Fact]
        public async Task GetRatingByProjectAndUser_ReturnsNotFoundResult_WhenRatingDoesNotExist()
        {
            // Arrange
            var projectId = 1;
            var userId = 1;

            _mockProjectRepository.Setup(repo => repo.GetRatingByProjectAndUser(projectId, userId))
                .ReturnsAsync((RatingDTO)null);

            // Act
            var result = await _projectController.GetRatingByProjectAndUser(projectId, userId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetProjectsByUserId_ReturnsProjects_WhenProjectsExist()
        {
            // Arrange
            var userId = 1;
            var expectedProjects = new List<ProjectDTO>
            {
                new ProjectDTO { Id = 1, Name = "Project 1", Description = "Description 1", ShortDescription = "Short Desc 1", Status = "Status 1" },
                new ProjectDTO { Id = 2, Name = "Project 2", Description = "Description 2", ShortDescription = "Short Desc 2", Status = "Status 2" }
            };

            _mockProjectRepository.Setup(repo => repo.GetProjectsByUserId(userId))
                .ReturnsAsync(expectedProjects);

            // Act
            var result = await _projectController.GetProjectsByUserId(userId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedProjects = Assert.IsType<List<ProjectDTO>>(okResult.Value);
            Assert.Equal(expectedProjects.Count, returnedProjects.Count);
        }


        [Fact]
        public async Task GetProjectsByUserId_ReturnsEmptyList_WhenNoProjectsExist()
        {
            // Arrange
            var userId = 1;
            IEnumerable<ProjectDTO> emptyList = new List<ProjectDTO>();

            _mockProjectRepository.Setup(repo => repo.GetProjectsByUserId(userId)).ReturnsAsync(emptyList);

            // Act
            var result = await _projectController.GetProjectsByUserId(userId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var projects = Assert.IsType<List<ProjectDTO>>(okResult.Value);
            Assert.Empty(projects);
        }



    }
}
