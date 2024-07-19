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
    // Represents a test class for the SynergyController class.
    public class SynergyControllerTests
    {
        private readonly Mock<ISynergyRepository> _mockSynergyRepository;
        private readonly SynergyController _synergyController;

        public SynergyControllerTests()
        {
            _mockSynergyRepository = new Mock<ISynergyRepository>();
            _synergyController = new SynergyController(_mockSynergyRepository.Object);
        }

        [Fact]
        public async Task CreateSynergy_WhenSynergyDoesNotExist_ReturnsOk()
        {
            var mockSynergyModel = new SynergyModel
            {
                Type = "Type",
                Status = "Status",
                SourceProject = 1,
                TargetProject = 2
            };

            var expectedId = 1;

            _mockSynergyRepository.Setup(x => x.SynergyExistsByProjectsIds(mockSynergyModel.SourceProject, mockSynergyModel.TargetProject)).ReturnsAsync(false);
            _mockSynergyRepository.Setup(x => x.CreateSynergy(mockSynergyModel)).ReturnsAsync(expectedId);

            var result = await _synergyController.CreateSynergy(mockSynergyModel);

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var id = Assert.IsType<int>(actionResult.Value);

            Assert.Equal(expectedId, id);
        }

        [Fact]
        public async Task CreateSynergy_WhenSynergyExists_ReturnsBadRequest()
        {
            var mockSynergyModel = new SynergyModel
            {
                Type = "Type",
                Status = "Status",
                SourceProject = 1,
                TargetProject = 2
            };

            _mockSynergyRepository.Setup(x => x.SynergyExistsByProjectsIds(mockSynergyModel.SourceProject, mockSynergyModel.TargetProject)).ReturnsAsync(true);

            var result = await _synergyController.CreateSynergy(mockSynergyModel);

            var actionResult = Assert.IsType<BadRequestObjectResult>(result);
            var message = Assert.IsType<string>(actionResult.Value);

            Assert.Equal("Synergy already exists for these projects", message);
        }

        [Fact]
        public async Task GetSynergyById_WhenSynergyExists_ReturnsOk()
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

            _mockSynergyRepository.Setup(x => x.GetSynergyById(synergyId)).ReturnsAsync(expectedSynergy);

            var result = await _synergyController.GetSynergyById(synergyId);

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var synergy = Assert.IsType<SynergyDTO>(actionResult.Value);
            Assert.Equal(expectedSynergy, synergy);
        }

        [Fact]
        public async Task GetSynergyById_WhenSynergyDoesNotExist_ReturnsNotFound()
        {
            var synergyId = 999;
            _mockSynergyRepository.Setup(x => x.GetSynergyById(synergyId)).ReturnsAsync((SynergyDTO)null);

            var result = await _synergyController.GetSynergyById(synergyId);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task CreateSynergyUpdate_WhenSynergyExists_ReturnsOk()
        {
            var mockSynergyId = 1;
            var mockSynergyUpdateModel = new SynergyUpdateModel
            {
                Title = "Title",
                Description = "Description"
            };

            var expectedId = 1;

            _mockSynergyRepository.Setup(x => x.SynergyExistsBySynergyId(mockSynergyId)).ReturnsAsync(true);
            _mockSynergyRepository.Setup(x => x.CreateSynergyUpdate(mockSynergyId, mockSynergyUpdateModel)).ReturnsAsync(expectedId);

            var result = await _synergyController.CreateSynergyUpdate(mockSynergyId, mockSynergyUpdateModel);

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var id = Assert.IsType<int>(actionResult.Value);

            Assert.Equal(expectedId, id);

        }

        [Fact]
        public async Task CreateSynergyUpdate_WhenSynergyDoesNotExist_ReturnsBadRequest()
        {
            var mockSynergyId = 1;
            var mockSynergyModel = new SynergyUpdateModel
            {
                Title = "Title",
                Description = "Description"
            };

            _mockSynergyRepository.Setup(x => x.SynergyExistsBySynergyId(mockSynergyId)).ReturnsAsync(false);

            var result = await _synergyController.CreateSynergyUpdate(mockSynergyId, mockSynergyModel);

            var actionResult = Assert.IsType<BadRequestObjectResult>(result);
            var message = Assert.IsType<string>(actionResult.Value);

            Assert.Equal("Synergy ID does not exist", message);
        }

        [Fact]
        public async Task CreateSynergyUpdate_WhenCreateSynergyUpdateFails_ReturnsBadRequest()
        {
            var mockSynergyId = 1;
            var mockSynergyUpdateModel = new SynergyUpdateModel
            {
                Title = "Title",
                Description = "Description"
            };

            _mockSynergyRepository.Setup(x => x.SynergyExistsBySynergyId(mockSynergyId)).ReturnsAsync(true);
            _mockSynergyRepository.Setup(x => x.CreateSynergyUpdate(mockSynergyId, mockSynergyUpdateModel)).ReturnsAsync((int?)null);

            var result = await _synergyController.CreateSynergyUpdate(mockSynergyId, mockSynergyUpdateModel);

            var actionResult = Assert.IsType<BadRequestObjectResult>(result);
            var message = Assert.IsType<string>(actionResult.Value);

            Assert.Equal("Failed to create synergy update", message);
        }
        
        [Fact]
        public async Task GetUpdatesBySynergyId_ReturnsOk_WhenUpdatesExist()
        {
            // Arrange
            var synergyId = 1;
            var expectedUpdates = new List<SynergyUpdateDTO>
            {
                new SynergyUpdateDTO { Id = 1, Title = "Update 1", Description = "Description 1", Datetime = DateTime.Now },
                new SynergyUpdateDTO { Id = 2, Title = "Update 2", Description = "Description 2", Datetime = DateTime.Now.AddMinutes(-10) }
            };

            _mockSynergyRepository.Setup(repo => repo.GetUpdatesBySynergyId(synergyId)).ReturnsAsync(expectedUpdates);

            // Act
            var result = await _synergyController.GetUpdatesBySynergyId(synergyId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedUpdates = Assert.IsType<List<SynergyUpdateDTO>>(okResult.Value);
            Assert.Equal(expectedUpdates.Count, returnedUpdates.Count);
        }

        [Fact]
        public async Task GetUpdatesBySynergyId_ReturnsOk_WhenNoUpdatesExist()
        {
            // Arrange
            var synergyId = 1;
            var expectedUpdates = new List<SynergyUpdateDTO>();

            _mockSynergyRepository.Setup(repo => repo.GetUpdatesBySynergyId(synergyId)).ReturnsAsync(expectedUpdates);

            // Act
            var result = await _synergyController.GetUpdatesBySynergyId(synergyId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedUpdates = Assert.IsType<List<SynergyUpdateDTO>>(okResult.Value);
            Assert.Empty(returnedUpdates);
        }


    }
}