using Xunit;
using CoreService.Controllers;
using CoreService.Models;
using CoreService.DTOs;
using CoreService.Repositories;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreService.Tests.ControllersTests
{
    // Represents a test class for the MacroThemeController class.
    public class MacroThemeControllerTests
    {
        private readonly Mock<IMacroThemeRepository> _mockMacroThemeRepository;
        private readonly MacroThemeController _macroThemeController;

        public MacroThemeControllerTests()
        {
            _mockMacroThemeRepository = new Mock<IMacroThemeRepository>();
            _macroThemeController = new MacroThemeController(_mockMacroThemeRepository.Object);
        }

        [Fact]
        public async Task GetAllMacroThemes_ReturnsListOfMacroThemes_WhenMacroThemesExist()
        {
            // Arrange
            var expectedMacroThemes = new List<MacroThemeDTO>
            {
                new MacroThemeDTO { Id = 1, Name = "Education" },
                new MacroThemeDTO { Id = 2, Name = "Healthcare" }
            };

            _mockMacroThemeRepository.Setup(repo => repo.GetAllMacroThemes())
                .ReturnsAsync(expectedMacroThemes);

            // Act
            var result = await _macroThemeController.GetAllMacroThemes();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedMacroThemes = Assert.IsType<List<MacroThemeDTO>>(okResult.Value);
            Assert.Equal(2, returnedMacroThemes.Count);
        }

        [Fact]
        public async Task GetAllMacroThemes_ReturnsEmptyList_WhenNoMacroThemesExist()
        {
            // Arrange
            var expectedMacroThemes = new List<MacroThemeDTO>();

            _mockMacroThemeRepository.Setup(repo => repo.GetAllMacroThemes())
                .ReturnsAsync(expectedMacroThemes);

            // Act
            var result = await _macroThemeController.GetAllMacroThemes();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedMacroThemes = Assert.IsType<List<MacroThemeDTO>>(okResult.Value);
            Assert.Empty(returnedMacroThemes);
        }

        [Fact]
        public async Task GetProjectsByMacroThemeId_ReturnsListOfProjects_WhenProjectsExist()
        {
            // Arrange
            var expectedProjects = new List<ProjectDTO>
            {
                new ProjectDTO { Id = 1, Name = "Project 1", Description = "Description 1", ShortDescription = "Short Desc 1", Status = "Status 1", User = "User 1", Enterprise = "Enterprise 1", Microtheme = "Microtheme 1", Macrotheme = "Macrotheme 1" },
                new ProjectDTO { Id = 2, Name = "Project 2", Description = "Description 2", ShortDescription = "Short Desc 2", Status = "Status 2", User = "User 2", Enterprise = "Enterprise 2", Microtheme = "Microtheme 2", Macrotheme = "Macrotheme 2" }
            };

            _mockMacroThemeRepository.Setup(repo => repo.GetProjectsByMacroThemeId(1))
                .ReturnsAsync(expectedProjects);

            // Act
            var result = await _macroThemeController.GetProjectsByMacroThemeId(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedProjects = Assert.IsType<List<ProjectDTO>>(okResult.Value);
            Assert.Equal(2, returnedProjects.Count);
        }

        [Fact]
        public async Task GetProjectsByMacroThemeId_ReturnsEmptyList_WhenNoProjectsExist()
        {
            // Arrange
            var expectedProjects = new List<ProjectDTO>();

            _mockMacroThemeRepository.Setup(repo => repo.GetProjectsByMacroThemeId(1))
                .ReturnsAsync(expectedProjects);

            // Act
            var result = await _macroThemeController.GetProjectsByMacroThemeId(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedProjects = Assert.IsType<List<ProjectDTO>>(okResult.Value);
            Assert.Empty(returnedProjects);
        }

        [Fact]
        public async Task GetMicroThemesByMacroThemeId_ReturnsListOfMicroThemes_WhenMicroThemesExist()
        {
            // Arrange
            var expectedMicroThemes = new List<MicroThemeDTO>
            {
                new MicroThemeDTO { Id = 1, Name = "Microtheme 1" },
                new MicroThemeDTO { Id = 2, Name = "Microtheme 2" }
            };

            _mockMacroThemeRepository.Setup(repo => repo.GetMicroThemesByMacroThemeId(1))
                .ReturnsAsync(expectedMicroThemes);

            // Act
            var result = await _macroThemeController.GetMicroThemesByMacroThemeId(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedMicroThemes = Assert.IsType<List<MicroThemeDTO>>(okResult.Value);
            Assert.Equal(2, returnedMicroThemes.Count);
        }

        [Fact]
        public async Task GetMicroThemesByMacroThemeId_ReturnsEmptyList_WhenNoMicroThemesExist()
        {
            // Arrange
            var expectedMicroThemes = new List<MicroThemeDTO>();

            _mockMacroThemeRepository.Setup(repo => repo.GetMicroThemesByMacroThemeId(1))
                .ReturnsAsync(expectedMicroThemes);

            // Act
            var result = await _macroThemeController.GetMicroThemesByMacroThemeId(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedMicroThemes = Assert.IsType<List<MicroThemeDTO>>(okResult.Value);
            Assert.Empty(returnedMicroThemes);
        }

    }
}
