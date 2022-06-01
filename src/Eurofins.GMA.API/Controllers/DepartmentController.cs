using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eurofins.GMA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public async Task<IEnumerable<DepartmentDto>> Get()
        {
            return await _service.GetAllDepartmentsAsync();
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public async Task<DepartmentDto> Get(short id)
        {
            return await _service.GetDepartmentAsync(id);
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public async Task Post([FromBody] DepartmentDto value)
        {
            await _service.CreateDepartmentAsync(value);
        }

        // PUT api/<DepartmentController>
        [HttpPut]
        public async Task Put([FromBody] DepartmentDto value)
        {
            await _service.UpdateDepartmentAsync(value);
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public async Task Delete(short id)
        {
            await _service.DeleteDepartmentAsync(id);
        }
    }
}
