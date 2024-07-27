using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrayController : ControllerBase
    {
        private readonly IService<TrayDto> service;
        public TrayController(IService<TrayDto> service)
        {
            this.service = service;
        }
        // GET: api/<TrayController>
        [HttpGet]
        public async Task<List<TrayDto>> Get()
        {
            return await service.GetAll();
        }

        // GET api/<TrayController>/5
        [HttpGet("{id}")]
        public async Task<TrayDto> Get(int id)
        {
            return await service.GetById(id); 
        }

        // POST api/<TrayController>
        [HttpPost]
        public async Task Post([FromBody] TrayDto value)
        {
            await service.Add(value);
        }

        // PUT api/<TrayController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] TrayDto value)
        {
            await service.Update(id, value);
        }

        // DELETE api/<TrayController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Delete(id);
        }
    }
}
