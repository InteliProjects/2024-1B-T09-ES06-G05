using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CoreService.Repositories
{
    // This class is used to access the database
	public class DbAccess : IDbAccess
	{
        // Inject IDbConnection
		private readonly IDbConnection _db;

        // Constructor to initialize the DbAccess class
		public DbAccess(IDbConnection dbConnection)
		{
			_db = dbConnection;
		}

        // Query the database and return the first result
		public async Task<T> QueryFirstAsync<T>(string sql, object parameters = null)
		{
			return await _db.QueryFirstAsync<T>(sql, parameters);
		}

        // Query the database and return the first result or default
        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object parameters = null)
        {
            return await _db.QueryFirstOrDefaultAsync<T>(sql, parameters);
        }

        // Execute a scalar query and return the result
        public async Task<T> ExecuteScalarAsync<T>(string sql, object parameters = null)
        {
            return await _db.ExecuteScalarAsync<T>(sql, parameters);
        }

        // Execute a query and return the number of rows affected
        public async Task<int> ExecuteAsync(string sql, object parameters = null)
        {
            return await _db.ExecuteAsync(sql, parameters);
        }

        // Query the database and return a list of results
        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object parameters = null)
        {
            return await _db.QueryAsync<T>(sql, parameters);
        }
    }

}