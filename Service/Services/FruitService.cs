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
    public class FruitService : IService<FruitDto>
    {
        private readonly IRepository<Fruit> repository;
        private readonly Mapper mapper;
        public FruitService(IRepository<Fruit> repository, Mapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task Add(FruitDto service)
        {
            await repository.Add(mapper.Map<Fruit>(service));
        }

        public async Task Delete(int id)
        {
            await repository.Remove(id);
        }

        public async Task<List<FruitDto>> GetAll()
        {
            return mapper.Map<List<FruitDto>>(await repository.GetAll());
        }

        public async Task<FruitDto> GetById(int id)
        {
            return mapper.Map<FruitDto>(await repository.GetAll());
        }

        public async Task Update(int id, FruitDto service)
        {
            await repository.Update(id,mapper.Map<Fruit>(service));
        }
    }
}
