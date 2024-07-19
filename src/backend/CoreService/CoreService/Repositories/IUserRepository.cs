using CoreService.DTOs;

namespace CoreService.Repositories
{
	// IUserRepository interface with methods to query the database
	public interface IUserRepository
	{
		Task<UserDTO> GetUserById(int id);
	}
}