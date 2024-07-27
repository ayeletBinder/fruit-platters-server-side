using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly IService<FruitDto> service;
        public FruitController(IService<FruitDto> service)
        {
            this.service = service;
        }
        // GET: api/<FruitController>
        [HttpGet]
        public async Task<List<FruitDto>> Get()
        {
            return await service.GetAll();
        }

        // GET api/<FruitController>/5
        [HttpGet("{id}")]
        public async Task<FruitDto> Get(int id)
        {
            return await service.GetById(id);
        }

        // POST api/<FruitController>
        [HttpPost]
        public async Task Post([FromBody] FruitDto value)
        {
            await service.Add(value);
        }

        // PUT api/<FruitController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] FruitDto value)
        {
            await service.Update(id, value);
        }

        // DELETE api/<FruitController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Delete(id);
        }
    }
}
