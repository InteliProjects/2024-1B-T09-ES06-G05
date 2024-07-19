using Xunit;
using AuthService.Controllers;
using AuthService.Models;
using AuthService.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace AuthService.Tests.ControllersTests
{
    // Represents a test class for the AuthController class.
    public class AuthControllerTests
    {
        private readonly Mock<IAuthRepository> _mockAuthRepository;
        private readonly Mock<IConfiguration> _mockConfiguration;
        private readonly AuthController _authController;

        // Initializes a new instance of the AuthControllerTests class.
        public AuthControllerTests()
        {
            _mockAuthRepository = new Mock<IAuthRepository>();
            _mockConfiguration = new Mock<IConfiguration>();
            _authController = new AuthController(_mockAuthRepository.Object, _mockConfiguration.Object);
        }

        // Tests the Login method of the AuthController class when the credentials are correct.
        [Fact]
        public async Task Login_ReturnsOkResult_WhenCredentialsAreCorrect()
        {
            var mockLoginModel = new LoginModel { Email = "validEmail@example.com", Password = "password123" };
            var expectedId = 1;

            _mockAuthRepository.Setup(repo => repo.CheckCredentials(mockLoginModel.Email, mockLoginModel.Password)).ReturnsAsync(expectedId);

            _mockConfiguration.SetupGet(config => config["JwtConfig:Secret"]).Returns("supersecretkeymock123supersecretkeymock123");

            var result = await _authController.Login(mockLoginModel);

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var loginResponse = Assert.IsType<LoginResponseModel>(actionResult.Value);

            Assert.Equal(expectedId, loginResponse.Id);
            Assert.NotNull(loginResponse.Token);
        }

        // Tests the Login method of the AuthController class when the credentials are incorrect.
        [Fact]
        public async Task Login_ReturnsUnauthorizedResult_WhenCredentialsAreIncorrect()
        {
            var mockLoginModel = new LoginModel { Email = "invalidEmail@example.com", Password = "password123" };

            _mockAuthRepository.Setup(repo => repo.CheckCredentials(mockLoginModel.Email, mockLoginModel.Password)).ReturnsAsync((int?)null);

            var result = await _authController.Login(mockLoginModel);

            Assert.IsType<UnauthorizedResult>(result);
        }

        // Tests the GenerateToken method of the AuthController class when called with a user ID.
        [Fact]
        public void GenerateToken_ReturnsToken_WhenCalledWithUserId()
        {
            var userId = 1;
            _mockConfiguration.SetupGet(config => config["JwtConfig:Secret"])
                .Returns("supersecretkeymock123supersecretkeymock123");

            var token = _authController.GenerateToken(userId);
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(token);

            Assert.NotNull(jwtToken);
        }
    }
}
