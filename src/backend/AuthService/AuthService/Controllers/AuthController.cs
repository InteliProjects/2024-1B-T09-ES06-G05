using AuthService.Models;
using AuthService.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace AuthService.Controllers
{
    // Controller responsible for handling authentication-related requests.
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        private readonly IConfiguration _configuration;

        // Initializes a new instance of the "AuthController" class.
        public AuthController(IAuthRepository authRepository, IConfiguration configuration)
        {
            _authRepository = authRepository;
            _configuration = configuration;
        }

        // Handles the login request.
        
        [HttpPost("/login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var userId = await _authRepository.CheckCredentials(loginModel.Email, loginModel.Password);

            if (userId == null)
            {
                return Unauthorized();
            }

            var token = GenerateToken(userId.Value);
            return Ok(new LoginResponseModel { Id = userId.Value, Token = token });
        }

        // Generates a JWT token for the specified user ID.
        public string GenerateToken(int userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["JwtConfig:Secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}