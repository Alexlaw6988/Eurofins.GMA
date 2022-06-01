using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eurofins.GMA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get()
        {
            return await _service.GetAllUsersAsync();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> Get(int id)
        {
            return await _service.GetUserAsync(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task Post([FromBody] UserDto value)
        {
            await _service.CreateUserAsync(value);
        }

        // PUT api/<UsersController>
        [HttpPut]
        public async Task Put([FromBody] UserDto value)
        {
            await _service.UpdateUserAsync(value);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.DeleteUserAsync(id);
        }
    }
}
