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
    // Represents a test class for the MacroThemeRepository class.
    public class MacroThemeRepositoryTests
    {
        private readonly Mock<IDbAccess> _mockDbAccess;
        private readonly MacroThemeRepository _macroThemeRepository;

        public MacroThemeRepositoryTests()
        {
            _mockDbAccess = new Mock<IDbAccess>();
            _macroThemeRepository = new MacroThemeRepository(_mockDbAccess.Object);
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

            _mockDbAccess.Setup(db => db.QueryAsync<MacroThemeDTO>(It.IsAny<string>(),It.IsAny<object>())).ReturnsAsync(expectedMacroThemes);

            // Act
            var result = await _macroThemeRepository.GetAllMacroThemes();

            // Assert
            Assert.Equal(expectedMacroThemes, result);
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

            _mockDbAccess.Setup(db => db.QueryAsync<ProjectDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedProjects);

            // Act
            var result = await _macroThemeRepository.GetProjectsByMacroThemeId(1);

            // Assert
            Assert.Equal(expectedProjects, result);
        }

        [Fact]
        public async Task GetProjectsByMacroThemeId_ReturnsEmptyList_WhenNoProjectsExist()
        {
            // Arrange
            var expectedProjects = new List<ProjectDTO>();

            _mockDbAccess.Setup(db => db.QueryAsync<ProjectDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedProjects);

            // Act
            var result = await _macroThemeRepository.GetProjectsByMacroThemeId(1);

            // Assert
            Assert.Empty(result);
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

            _mockDbAccess.Setup(db => db.QueryAsync<MicroThemeDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedMicroThemes);

            // Act
            var result = await _macroThemeRepository.GetMicroThemesByMacroThemeId(1);

            // Assert
            Assert.Equal(expectedMicroThemes, result);
        }

        [Fact]
        public async Task GetMicroThemesByMacroThemeId_ReturnsEmptyList_WhenNoMicroThemesExist()
        {
            // Arrange
            var expectedMicroThemes = new List<MicroThemeDTO>();

            _mockDbAccess.Setup(db => db.QueryAsync<MicroThemeDTO>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedMicroThemes);

            // Act
            var result = await _macroThemeRepository.GetMicroThemesByMacroThemeId(1);

            // Assert
            Assert.Empty(result);
        }

    }
}
