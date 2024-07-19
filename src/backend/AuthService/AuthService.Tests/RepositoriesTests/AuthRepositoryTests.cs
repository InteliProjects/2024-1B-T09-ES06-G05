using AuthService.Repositories;
using Xunit;
using Moq;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace AuthService.Tests.RepositoriesTests
{
    // Represents a test class for the AuthRepository class.
    public class AuthRepositoryTests
    {
        private readonly Mock<IDbAccess> _mockDbAccess;
        private readonly AuthRepository _authRepository;

        // Initializes a new instance of the AuthRepositoryTests class.
        public AuthRepositoryTests()
        {
            _mockDbAccess = new Mock<IDbAccess>();
            _authRepository = new AuthRepository(_mockDbAccess.Object);
        }

        // Tests the CheckCredentials method of the AuthRepository class when the credentials are correct.
        [Fact]
        public async Task CheckCredentials_ReturnsId_WhenCredentialsAreCorrect()
        {
            var expectedId = 1;

            _mockDbAccess.Setup(x => x.QueryFirstOrDefaultAsync<int?>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(expectedId);

            var result = await _authRepository.CheckCredentials("validEmail@example.com", "password123");

            Assert.Equal(expectedId, result);
        }

        // Tests the CheckCredentials method of the AuthRepository class when the credentials are incorrect.
        [Fact]
        public async Task CheckCredentials_ReturnsNull_WhenCredentialsAreIncorrect()
        {
            _mockDbAccess.Setup(x => x.QueryFirstOrDefaultAsync<int?>(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync((int?)null);

            var result = await _authRepository.CheckCredentials("invalidEmail@example.com", "password123");

            Assert.Null(result);
        }
    }
}
