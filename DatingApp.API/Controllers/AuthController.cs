using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.DTO;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            this._repo = repo;
        }

        [HttpPost("register")] 
        public async Task<IActionResult> Register(UserForRegisterDTO userDTO)
        {
            //validate request

            userDTO.Username = userDTO.Username.ToLower();

            if (await _repo.UserExists(userDTO.Username))
                return BadRequest("Username already exists");

            var userToCreate = new User
            {
                Username = userDTO.Username
            };

            var createdUser = await _repo.Register(userToCreate, userDTO.Password);
            
            return StatusCode(201);
        }
    }
}