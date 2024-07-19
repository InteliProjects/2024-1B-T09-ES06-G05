using CoreService.Repositories;
using CoreService.Models;
using CoreService.DTOs;
using Xunit;
using Moq;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace CoreService.Tests.RepositoriesTests
{
    // Represents a test class for the ProjectRepository class.
    public class ProjectRepositoryTests
    {
        private readonly Mock<IDbAccess> _mockDbAccess;
        private readonly ProjectRepository _projectRepository;

        public ProjectRepositoryTests()
        {
            _mockDbAccess = new Mock<IDbAccess>();
            _projectRepository = new ProjectRepository(_mockDbAccess.Object);
        }

        // Test if recommended projects are returned
        [Fact]
        public async Task GetRecommendedProjects_ReturnsProjects_WhenProjectsExist()
        {
            // Arrange
            var userId = 1;
            var expectedProjects = new List<ProjectDTO>
            {
                new ProjectDTO { Id = 1, Name = "Project 1", Description = "Description 1", ShortDescription = "Short Description 1", Status = "Status 1", User = "User 1", Enterprise = "Enterprise 1", Microtheme = "Microtheme 1", Macrotheme = "Macrotheme 1" },
                new ProjectDTO { Id = 2, Name = "Project 2", Description = "Description 2", ShortDescription = "Short Description 2", Status = "Status 2", User = "User 2", Enterprise = "Enterprise 2", Microtheme = "Microtheme 2", Macrotheme = "Macrotheme 2" }
            };

            _mockDbAccess.Setup(x => x.QueryAsync<ProjectDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedProjects);

            // Act
            var result = await _projectRepository.GetRecommendedProjects(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedProjects.Count, result.ToList().Count);
            Assert.Equal(expectedProjects, result);
        }

        [Fact]
        public async Task GetProjectById_ReturnsProject_WhenProjectExists()
        {
            var projectId = 1;
            var expectedProject = new ProjectDTO
            {
                Id = 1,
                Name = "Project 1",
                Description = "Description 1",
                ShortDescription = "Short Description 1",
                Status = "Status 1",
                User = "User 1",
                Enterprise = "Enterprise 1",
                Microtheme = "Microtheme 1",
                Macrotheme = "Macrotheme 1"
            };

            _mockDbAccess.Setup(x => x.QueryFirstOrDefaultAsync<ProjectDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedProject);

            var result = await _projectRepository.GetProjectById(projectId);

            Assert.NotNull(result);
            Assert.Equal(expectedProject.Id, result.Id);
            Assert.Equal(expectedProject.Name, result.Name);
            Assert.Equal(expectedProject.Description, result.Description);
            Assert.Equal(expectedProject.ShortDescription, result.ShortDescription);
            Assert.Equal(expectedProject.Status, result.Status);
            Assert.Equal(expectedProject.User, result.User);
            Assert.Equal(expectedProject.Enterprise, result.Enterprise);
            Assert.Equal(expectedProject.Microtheme, result.Microtheme);
            Assert.Equal(expectedProject.Macrotheme, result.Macrotheme);
        }

        [Fact]
        public async Task GetProjectById_ReturnsNull_WhenProjectDoesNotExist()
        {
            var projectId = 1;

            _mockDbAccess.Setup(x => x.QueryFirstOrDefaultAsync<ProjectDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync((ProjectDTO)null);

            var result = await _projectRepository.GetProjectById(projectId);

            Assert.Null(result);
        }

        [Fact]
        public async Task CreateProject_ReturnsProjectId_WhenProjectIsCreated()
        {
            // Arrange
            var mockDb = new Mock<IDbAccess>();
            var projectModel = new ProjectModel
            {
                Name = "Test Project",
                Description = "Test Description",
                ShortDescription = "Short Description",
                Status = "Active",
                UserId = 1,
                MicrothemeId = 1
            };
            var expectedProjectId = 123;

            mockDb.Setup(db => db.ExecuteScalarAsync<int?>(It.IsAny<string>(), It.IsAny<object>()))
                  .ReturnsAsync(expectedProjectId);

            var repository = new ProjectRepository(mockDb.Object);

            // Act
            var projectId = await repository.CreateProject(projectModel);

            // Assert
            Assert.NotNull(projectId);
            Assert.Equal(expectedProjectId, projectId);
        }

        [Fact]
        public async Task CreateProject_ReturnsNull_WhenProjectCreationFails()
        {
            // Arrange
            var mockDb = new Mock<IDbAccess>();
            var projectModel = new ProjectModel
            {
                Name = "Test Project",
                Description = "Test Description",
                ShortDescription = "Short Description",
                Status = "Active",
                UserId = 1,
                MicrothemeId = 1
            };

            mockDb.Setup(db => db.ExecuteScalarAsync<int?>(It.IsAny<string>(), It.IsAny<object>()))
                  .ReturnsAsync((int?)null);

            var repository = new ProjectRepository(mockDb.Object);

            // Act
            var projectId = await repository.CreateProject(projectModel);

            // Assert
            Assert.Null(projectId);
        }

        // Test if project exists
        [Fact]
        public async Task ProjectExists_ReturnsTrue_WhenProjectExists()
        {
            var projectId = 1;
            var expectedCount = 1;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedCount);

            var result = await _projectRepository.ProjectExists(projectId);

            Assert.True(result);
        }

        [Fact]
        public async Task ProjectExists_ReturnsFalse_WhenProjectDoesNotExist()
        {
            var projectId = 1;
            var expectedCount = 0;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedCount);

            var result = await _projectRepository.ProjectExists(projectId);

            Assert.False(result);
        }

        [Fact]
        public async Task UpdateProject_WhenProjectExists_ReturnsTrue()
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

            _mockDbAccess.Setup(db => db.ExecuteAsync(It.IsAny<string>(), It.IsAny<object>()))
                .ReturnsAsync(1);

            // Act
            var result = await _projectRepository.UpdateProject(projectId, projectUpdateModel);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task GetSynergiesByProjectId_ReturnsSynergies_WhenProjectIdIsValid()
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

            _mockDbAccess.Setup(x => x.QueryAsync<ProjectSynergyDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedSynergies);

            // Act
            var synergies = await _projectRepository.GetSynergiesByProjectId(projectId);

            // Assert
            Assert.NotNull(synergies);
            Assert.Equal(expectedSynergies.Count, synergies.ToList().Count);
            Assert.Equal(expectedSynergies, synergies);
        }


        [Fact]
        public async Task GetSynergiesByProjectId_ReturnsEmptyArray_WhenNoSynergiesFoundForProjectId()
        {
            // Arrange
            var projectId = 999;
            _mockDbAccess.Setup(x => x.QueryAsync<ProjectSynergyDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(new List<ProjectSynergyDTO>());

            // Act
            var synergies = await _projectRepository.GetSynergiesByProjectId(projectId);

            // Assert
            Assert.NotNull(synergies);
            Assert.Empty(synergies);
        }

        // Test if project deletion is successful
        [Fact]
        public async Task DeleteProject_ReturnsTrue_WhenProjectIsDeleted()
        {
            var projectId = 1;
            var expectedCount = 1;

            _mockDbAccess.Setup(x => x.ExecuteAsync(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedCount);

            var result = await _projectRepository.DeleteProject(projectId);

            Assert.True(result);
        }

        // Test if the project rating is added successfully
        [Fact]
        public async Task AddRatingToProject_ReturnsRatingId_WhenRatingIsAdded()
        {
            var projectId = 1;
            var ratingModel = new RatingModel
            {
                Rating = 5,
                UserId = 1
            };
            var expectedId = 1;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int?>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedId);

            var result = await _projectRepository.AddRatingToProject(projectId, ratingModel);

            Assert.Equal(expectedId, result);
        }

        [Fact]
        public async Task GetRatingByProjectAndUser_ReturnsRating_WhenRatingExists()
        {
            // Arrange
            var projectId = 1;
            var userId = 1;
            var expectedRating = new RatingDTO
            {
                Id = 1,
                Rating = 5
            };

            _mockDbAccess.Setup(db => db.QueryFirstOrDefaultAsync<RatingDTO>(It.IsAny<string>(), It.IsAny<object>()))
                .ReturnsAsync(expectedRating);

            // Act
            var result = await _projectRepository.GetRatingByProjectAndUser(projectId, userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedRating.Id, result.Id);
            Assert.Equal(expectedRating.Rating, result.Rating);
        }

        [Fact]
        public async Task GetRatingByProjectAndUser_ReturnsNull_WhenRatingDoesNotExist()
        {
            // Arrange
            var projectId = 1;
            var userId = 1;

            _mockDbAccess.Setup(db => db.QueryFirstOrDefaultAsync<RatingDTO>(It.IsAny<string>(), It.IsAny<object>()))
                .ReturnsAsync((RatingDTO)null);

            // Act
            var result = await _projectRepository.GetRatingByProjectAndUser(projectId, userId);

            // Assert
            Assert.Null(result);
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

            _mockDbAccess.Setup(x => x.QueryAsync<ProjectDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedProjects);

            // Act
            var result = await _projectRepository.GetProjectsByUserId(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedProjects.Count, result.ToList().Count);
            Assert.Equal(expectedProjects, result);
        }

        [Fact]
        public async Task GetProjectsByUserId_ReturnsEmptyList_WhenNoProjectsExist()
        {
            // Arrange
            var userId = 1;
            var expectedProjects = new List<ProjectDTO>();

            _mockDbAccess.Setup(x => x.QueryAsync<ProjectDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedProjects);

            // Act
            var result = await _projectRepository.GetProjectsByUserId(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }


    }
}
