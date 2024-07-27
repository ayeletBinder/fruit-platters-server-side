using AutoMapper;
using Common.Dtos;
using Repository.Entity;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CommentService : IService<CommentDto>
    {
        private readonly IRepository<Comment> repository;
        private readonly IMapper mapper;
        public CommentService(IRepository<Comment> repository, Mapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task Add(CommentDto service)
        {
           await repository.Add(mapper.Map<Comment>(service));
        }

        public async Task Delete(int id)
        {
            await repository.Remove(id);
        }

        public async Task<List<CommentDto>> GetAll()
        {
            return  mapper.Map<List<CommentDto>>(await repository.GetAll());
        }

        public async Task<CommentDto> GetById(int id)
        {
            return  mapper.Map<CommentDto>(await repository.GetById(id));
        }

        public async Task Update(int id, CommentDto service)
        {
           await repository.Update(id,mapper.Map<Comment>(service));
        }
    }
}
