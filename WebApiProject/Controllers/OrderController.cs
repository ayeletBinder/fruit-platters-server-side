using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IService<OrderDto> service;
        public OrderController(IService<OrderDto> service)
        {
            this.service = service;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public async Task<List<OrderDto>> Get()
        {
            return await this.service.GetAll();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<OrderDto> Get(int id)
        {
            return await this.service.GetById(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task Post([FromBody] OrderDto value)
        {
            await service.Add(value);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] OrderDto value)
        {
            await service.Update(id, value);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await this.service.Delete(id);
        }
    }
}
