using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RMS.Api.Core.Contracts;
using RMS.Api.Core.DTO;
using RMS.Api.Core.Models;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository= userRepository;    
        }
        // GET: api/<UsersController>
        [HttpGet]
        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _userRepository.GetUserId(id) ;
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserDto value)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(await _userRepository.AddUser(value));
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UserDto value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(await _userRepository.UpdateUser(id,value));
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(await _userRepository.RemoveUser(id));
        }
    }
}
