using CoreService.Repositories;
using CoreService.Models;
using Xunit;
using Moq;
using System.Threading.Tasks;
using CoreService.DTOs;
using System.Data;
using Dapper;

namespace CoreService.Tests.RepositoriesTests
{
    // Represents a test class for the SynergyRepository class.
    public class SynergyRepositoryTests
    {
        private readonly Mock<IDbAccess> _mockDbAccess;
        private readonly SynergyRepository _synergyRepository;

        public SynergyRepositoryTests()
        {
            _mockDbAccess = new Mock<IDbAccess>();
            _synergyRepository = new SynergyRepository(_mockDbAccess.Object);
        }

        [Fact]
        public async Task SynergyExistsByProjectsId_ReturnsTrue_WhenSynergyExists()
        {
            var sourceProjectId = 1;
            var targetProjectId = 2;
            var expectedCount = 1;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedCount);

            var result = await _synergyRepository.SynergyExistsByProjectsIds(sourceProjectId, targetProjectId);

            Assert.True(result);
        }

        [Fact]
        public async Task SynergyExistsByProjectsId_ReturnsFalse_WhenSynergyDoesNotExist()
        {
            var sourceProjectId = 1;
            var targetProjectId = 2;
            var expectedCount = 0;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedCount);

            var result = await _synergyRepository.SynergyExistsByProjectsIds(sourceProjectId, targetProjectId);

            Assert.False(result);
        }

        [Fact]
        public async Task CreateSynergy_ReturnsId_WhenSynergyIsCreated()
        {
            var mockSynergyModel = new SynergyModel
            {
                SourceProject = 1,
                TargetProject = 2,
                Type = "Type",
                Status = "Status"
            };
            var expectedId = 1;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int?>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedId);

            var result = await _synergyRepository.CreateSynergy(mockSynergyModel);

            Assert.Equal(expectedId, result);
        }

        [Fact]
        public async Task GetSynergyById_ReturnsSynergy_WhenSynergyExists()
        {
            var synergyId = 1;
            var expectedSynergy = new SynergyDTO
            {
                Id = 1,
                Type = "Type",
                Status = "Status",
                SourceProjectId = 1,
                SourceProjectName = "Test Source Project",
                SourceUserName = "Test Source User",
                SourceUserEnterprise = "Test Source Enterprise",
                SourceMicrotheme = "Test Source Microtheme",
                SourceMacrotheme = "Test Source Macrotheme",
                TargetProjectId = 2,
                TargetProjectName = "Test Target Project",
                TargetUserName = "Test Target User",
                TargetUserEnterprise = "Test Target Enterprise",
                TargetMicrotheme = "Test Target Microtheme",
                TargetMacrotheme = "Test Target Macrotheme"
            };

            _mockDbAccess.Setup(x => x.QueryFirstOrDefaultAsync<SynergyDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedSynergy);

            var result = await _synergyRepository.GetSynergyById(synergyId);

            Assert.Equal(expectedSynergy, result);
        }

        [Fact]
        public async Task GetSynergyById_ReturnsNull_WhenSynergyDoesNotExist()
        {
            var synergyId = 999;
            _mockDbAccess.Setup(x => x.QueryFirstOrDefaultAsync<SynergyDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync((SynergyDTO)null);

            var result = await _synergyRepository.GetSynergyById(synergyId);

            Assert.Null(result);
        }

        [Fact]
        public async Task SynergyExistsBySynergyId_ReturnsTrue_WhenSynergyExists()
        {
            var synergyId = 1;
            var expectedCount = 1;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedCount);

            var result = await _synergyRepository.SynergyExistsBySynergyId(synergyId);

            Assert.True(result);
        }

        [Fact]
        public async Task SynergyExistsBySynergyId_ReturnsFalse_WhenSynergyDoesNotExist()
        {
            var synergyId = 1;
            var expectedCount = 0;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedCount);

            var result = await _synergyRepository.SynergyExistsBySynergyId(synergyId);

            Assert.False(result);
        }

        [Fact]
        public async Task CreateSynergyUpdate_ReturnsId_WhenSynergyUpdateIsCreated()
        {
            var synergyId = 1;
            var mockSynergyUpdateModel = new SynergyUpdateModel
            {
                Title = "Title",
                Description = "Description"
            };
            var expectedId = 1;

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int?>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedId);

            var result = await _synergyRepository.CreateSynergyUpdate(synergyId, mockSynergyUpdateModel);

            Assert.Equal(expectedId, result);
        }

        [Fact]
        public async Task CreateSynergyUpdate_ReturnsNull_WhenSynergyUpdateCreationFails()
        {
            var synergyId = 1;
            var mockSynergyUpdateModel = new SynergyUpdateModel
            {
                Title = "Title",
                Description = "Description"
            };

            _mockDbAccess.Setup(x => x.ExecuteScalarAsync<int?>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync((int?)null);

            var result = await _synergyRepository.CreateSynergyUpdate(synergyId, mockSynergyUpdateModel);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetUpdatesBySynergyId_ReturnsUpdates_WhenUpdatesExist()
        {
            // Arrange
            var synergyId = 1;
            var expectedUpdates = new List<SynergyUpdateDTO>
            {
                new SynergyUpdateDTO { Id = 1, Title = "Update 1", Description = "Description 1", Datetime = DateTime.Now },
                new SynergyUpdateDTO { Id = 2, Title = "Update 2", Description = "Description 2", Datetime = DateTime.Now.AddMinutes(-10) }
            };

            _mockDbAccess.Setup(db => db.QueryAsync<SynergyUpdateDTO>(It.IsAny<string>(), It.IsAny<object>()))
                         .ReturnsAsync(expectedUpdates);

            // Act
            var result = await _synergyRepository.GetUpdatesBySynergyId(synergyId);

            // Assert
            Assert.Equal(expectedUpdates.Count, result.Count());
            Assert.Equal(expectedUpdates, result);
        }

        [Fact]
        public async Task GetUpdatesBySynergyId_ReturnsEmptyList_WhenNoUpdatesExist()
        {
            // Arrange
            var synergyId = 1;
            var expectedUpdates = new List<SynergyUpdateDTO>();

            _mockDbAccess.Setup(db => db.QueryAsync<SynergyUpdateDTO>(It.IsAny<string>(), It.IsAny<object>()))
                         .ReturnsAsync(expectedUpdates);

            // Act
            var result = await _synergyRepository.GetUpdatesBySynergyId(synergyId);

            // Assert
            Assert.Empty(result);
        }
    }


}