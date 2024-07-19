using CoreService.Repositories;
using Xunit;
using Moq;
using System.Threading.Tasks;
using CoreService.DTOs;
using System.Data;
using Dapper;

namespace CoreService.Tests.RepositoriesTests
{
    // Represents a test class for the UserRepository class.
	public class UserRepositoryTests
	{
        private readonly Mock<IDbAccess> _mockDbAccess;
        private readonly UserRepository _userRepository;

        public UserRepositoryTests()
        {
            _mockDbAccess = new Mock<IDbAccess>();
            _userRepository = new UserRepository(_mockDbAccess.Object);
        }

        [Fact]
		public async Task GetUserById_ReturnsUser_WhenUserExists()
		{
            var mockUserDTO = new UserDTO
            {
                Id = 1,
                Name = "Test User",
                Enterprise = "Test",
                Position = "Developer",
                Email = "test@example.com",
                Password = "password123"
            };

            _mockDbAccess.Setup(x => x.QueryFirstAsync<UserDTO>(It.IsAny<string>(),It.IsAny<object>())).ReturnsAsync(mockUserDTO);

            var result = await _userRepository.GetUserById(1);

            Assert.Equal(mockUserDTO.Id, result.Id);
            Assert.Equal(mockUserDTO.Name, result.Name);
            Assert.Equal(mockUserDTO.Enterprise, result.Enterprise);
            Assert.Equal(mockUserDTO.Position, result.Position);
            Assert.Equal(mockUserDTO.Email, result.Email);
			Assert.Equal(mockUserDTO.Password, result.Password);
        }

		[Fact]
		public async Task GetUserById_ReturnsNull_WhenUserDoesNotExist()
		{
			_mockDbAccess.Setup(x => x.QueryFirstAsync<UserDTO>(It.IsAny<string>(),It.IsAny<object>())).ReturnsAsync((UserDTO)null);

			var result = await _userRepository.GetUserById(1);

			Assert.Null(result);

		}
	}

	
}   