using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Repository.Entity;
using Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IService<CommentDto> service;
        public CommentController(IService<CommentDto> service)
        {
            this.service = service;
        }
        // GET: api/<CommentController>
        [HttpGet]
        public async Task<List<CommentDto>> Get()
        {
            return await service.GetAll();
        }

        // GET api/<CommentController>/5
        [HttpGet("{id}")]
        public async Task<CommentDto> Get(int id)
        {
            return await service.GetById(id);
        }

        // POST api/<CommentController>
        [HttpPost]
        public async Task Post([FromBody] CommentDto value)
        {
            await service.Add(value);
        }

        // PUT api/<CommentController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] CommentDto value)
        {
            await service.Update(id, value);
        }

        // DELETE api/<CommentController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Delete(id);
        }
    }
}
