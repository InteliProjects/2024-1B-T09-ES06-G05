using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace AuthService.Repositories
{
	// Provides access to the database for executing queries.
	public class DbAccess : IDbAccess
	{
		private readonly IDbConnection _db;

		/// Initializes a new instance of the "DbAccess" class.
		public DbAccess(IDbConnection dbConnection)
		{
			_db = dbConnection;
		}

		// Executes a query and returns the first result, or the default value if no result is found.
		public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object parameters = null)
		{
			return await _db.QueryFirstOrDefaultAsync<T>(sql, parameters);
		}
	}
}