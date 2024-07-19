using Xunit;
using CoreService.Controllers;
using CoreService.Models;
using CoreService.Repositories;
using CoreService.DTOs;
using Microsoft.AspNetCore.Mvc;
using Moq;
using AutoMapper;

namespace CoreService.Tests.ControllersTests
{
    // Represents a test class for the UserController class.
    public class UserControllerTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly UserController _userController;

        public UserControllerTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _mockMapper = new Mock<IMapper>();
            _userController = new UserController(_mockUserRepository.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task GetUserById_ReturnsOkResult_WhenUserExists()
        {
            var mockUserDTO = new UserDTO
            {
                Id = 1,
                Name = "Test User",
                Enterprise = "TestCo",
                Position = "Developer",
                Email = "test@example.com",
                Password = "securepassword123"
            };

            var mockUserModel = new UserModel
            {
                Id = 1,
                Name = "Test User",
                Enterprise = "TestCo",
                Position = "Developer",
                Email = "test@example.com"
            };

            _mockUserRepository.Setup(repo => repo.GetUserById(1)).ReturnsAsync(mockUserDTO);
            _mockMapper.Setup(mapper => mapper.Map<UserModel>(It.IsAny<UserDTO>())).Returns(mockUserModel);

            var result = await _userController.GetUserById(1);

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var returnedUser = Assert.IsType<UserModel>(actionResult.Value);

            Assert.Equal(mockUserModel, returnedUser);
            _mockMapper.Verify(mapper => mapper.Map<UserModel>(mockUserDTO), Times.Once);

        }

        [Fact]
        public async Task GetUserById_ReturnsNotFoundResult_WhenUserDoesNotExist()
        {
            _mockUserRepository.Setup(repo => repo.GetUserById(1)).ReturnsAsync((UserDTO)null);

            var result = await _userController.GetUserById(1);

            var actionResult = Assert.IsType<NotFoundResult>(result);

        }
        [Fact]
        public async Task GetUserById_WhenUserExists_ReturnsOkResult()
        {
            // Arrange
            var mockUserDTO = new UserDTO
            {
                Id = 1,
                Name = "Test User",
                Enterprise = "TestCo",
                Position = "Developer",
                Email = "test@example.com",
                Password = "securepassword123"
            };

            var mockUserModel = new UserModel
            {
                Id = 1,
                Name = "Test User",
                Enterprise = "TestCo",
                Position = "Developer",
                Email = "test@example.com"
            };

            _mockUserRepository.Setup(repo => repo.GetUserById(1)).ReturnsAsync(mockUserDTO);
            _mockMapper.Setup(mapper => mapper.Map<UserModel>(It.IsAny<UserDTO>())).Returns(mockUserModel);

            // Act
            var result = await _userController.GetUserById(1);

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var returnedUser = Assert.IsType<UserModel>(actionResult.Value);

            Assert.Equal(mockUserModel.Id, returnedUser.Id);
            Assert.Equal(mockUserModel.Name, returnedUser.Name);
            Assert.Equal(mockUserModel.Enterprise, returnedUser.Enterprise);
            Assert.Equal(mockUserModel.Position, returnedUser.Position);
            Assert.Equal(mockUserModel.Email, returnedUser.Email);

            _mockMapper.Verify(mapper => mapper.Map<UserModel>(mockUserDTO), Times.Once);
        }

        [Fact]
        public async Task GetUserById_WhenUserDoesNotExist_ReturnsNotFoundResult()
        {
            // Arrange
            _mockUserRepository.Setup(repo => repo.GetUserById(1)).ReturnsAsync((UserDTO)null);

            // Act
            var result = await _userController.GetUserById(1);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
    
}