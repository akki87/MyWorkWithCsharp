using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMS.Api.Core.Contracts;
using RMS.Api.Core.DTO;
using RMS.Api.Core.Models;

namespace RMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        private IUserRepository _userRepository;
        public AuthsController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        [Route("Register")]
        public ActionResult Register([FromQuery] UserDto userDto)
        {
            if(ModelState.IsValid)
            {
                _userRepository.AddUser(userDto);
                return Ok("Registration Successful");
            }

            else
            {
                return BadRequest();
            }
        }
    }
}
