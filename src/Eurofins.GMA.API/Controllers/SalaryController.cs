using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eurofins.GMA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService _service;

        public SalaryController(ISalaryService service)
        {
            _service = service;
        }

        // GET api/<SalaryController>/5
        [HttpGet("{id}")]
        public async Task<SalaryDto> Get(long id)
        {
            return await _service.GetSalaryAsync(id);
        }

        // POST api/<SalaryController>
        [HttpPost]
        public async Task Post([FromBody] SalaryDto value)
        {
            await _service.CreateSalaryAsync(value);
        }

        // PUT api/<SalaryController>
        [HttpPut]
        public async Task Put([FromBody] SalaryDto value)
        {
            await _service.UpdateSalaryAsync(value);
        }

        // DELETE api/<SalaryController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.DeleteSalaryAsync(id);
        }
    }
}
