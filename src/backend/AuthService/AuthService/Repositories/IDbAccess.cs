using System.Threading.Tasks;
using System.Collections.Generic;

namespace AuthService.Repositories
{
	// Represents an interface for accessing the database.
	public interface IDbAccess
	{
		/// Executes a query and returns the first result, or the default value if no result is found.
		Task<T> QueryFirstOrDefaultAsync<T>(string sql, object parameters = null);
	}
}