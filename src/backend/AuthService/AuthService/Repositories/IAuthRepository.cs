namespace AuthService.Repositories
{
    // Represents an interface for the authentication repository.
    public interface IAuthRepository
    {
        // Checks the credentials of a user.
        Task<int?> CheckCredentials(string email, string password);
    }
}