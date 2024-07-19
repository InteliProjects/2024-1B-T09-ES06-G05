using Dapper;
using System.Data;
using Npgsql;
using CoreService.Models;
using CoreService.DTOs;

namespace CoreService.Repositories
{

	// UserRepository class with methods to query the database
	public class UserRepository : IUserRepository
	{
		// IDbAccess object to query the database
        private readonly IDbAccess _db;

		// Constructor to initialize the UserRepository class
        public UserRepository(IDbAccess dbAccess)
        {
            _db = dbAccess;
        }

		// Get user by id from the database
        public async Task<UserDTO> GetUserById(int id)
		{
			var sql = "SELECT * FROM \"user\" WHERE id = @Id";
			var result = await _db.QueryFirstAsync<UserDTO>(sql, new { id });
			return result;
		}

	}
}