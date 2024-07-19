using System.Threading.Tasks;
using System.Collections.Generic;

namespace CoreService.Repositories
{
    // IDbAccess interface with methods to query the database
	public interface IDbAccess
	{
		Task<T> QueryFirstAsync<T>(string sql, object parameters = null);
        Task<T> QueryFirstOrDefaultAsync<T>(string sql, object parameters = null);
        Task<int> ExecuteAsync(string sql, object parameters = null);
        Task<T> ExecuteScalarAsync<T>(string sql, object parameters = null);
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object parameters = null);
    }

}