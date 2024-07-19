using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CoreService.Repositories;
using CoreService.Models;
using CoreService.DTOs;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using CoreService.Utils;


namespace CoreService.Controllers
{
    // Specifies that this class is an API controller
    [ApiController]
    [Route("users")]
    [Authorize]

    public class UserController : ControllerBase
    {
        // Inject the user repository and mapper
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        // Constructor to initialize the user controller
        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        // Endpoint to get a user by ID
        [HttpGet("{id}")]
        [REQ("REQ-08")]
        public async Task<IActionResult> GetUserById(int id)
        {
            // Call the repository method to get the user by ID
            var userDTO = await _userRepository.GetUserById(id);

            // Return a 404 Not Found response if the user does not exist
            if (userDTO == null)
            {
                return NotFound();
            }

            // Map the user DTO to a user model and return with a 200 OK response
            var userModel = _mapper.Map<UserModel>(userDTO);

            // Return the user with a 200 OK response
            return Ok(userModel);
        }
    }
}