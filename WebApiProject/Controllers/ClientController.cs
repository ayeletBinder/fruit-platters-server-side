using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Repository.Entity;
using Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IService<ClientDto> service;
        public ClientController(IService<ClientDto> service)
        {
             this.service = service;
        }
        // GET: api/<ClientController>
        [HttpGet]
        public async Task<List<ClientDto>> Get()
        {
            return await this.service.GetAll();
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<ClientDto> Get(int id)
        {
            return await this.service.GetById(id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task Post([FromBody] ClientDto value)
        {
            await service.Add(value);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ClientDto value)
        {
            await service.Update(id,value); 
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Delete(id);
        }
    }
}
