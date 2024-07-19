namespace AuthService.Repositories
{
    // Repository class for authentication related operations.
    public class AuthRepository : IAuthRepository
    {
        private readonly IDbAccess _db;

        // Initializes a new instance of the "AuthRepository" class.
        public AuthRepository(IDbAccess dbAccess)
        {
            _db = dbAccess;
        }

        // Checks the credentials of a user.
        public async Task<int?> CheckCredentials(string email, string password)
        {
            var sql = "SELECT id FROM \"user\" WHERE email = @Email AND password = @Password";
            var result = await _db.QueryFirstOrDefaultAsync<int?>(sql, new { Email = email, Password = password });
            return result;
        }
    }
}