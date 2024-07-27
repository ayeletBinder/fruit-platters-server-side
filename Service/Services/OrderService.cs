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
    public class OrderService : IService<OrderDto>
    {
        private readonly IRepository<Order> repository;
        private readonly Mapper mapper;
        public OrderService(IRepository<Order> repository, Mapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task Add(OrderDto service)
        {
           await repository.Add(mapper.Map<Order>(service));
        }

        public async Task Delete(int id)
        {
           await repository.Remove(id);
        }

        public async Task<List<OrderDto>> GetAll()
        {
            return mapper.Map<List<OrderDto>>(repository.GetAll());
        }

        public async Task<OrderDto> GetById(int id)
        {
            return mapper.Map<OrderDto>(await repository.GetAll());
        }

        public async Task Update(int id, OrderDto service)
        {
           await repository.Update(id, mapper.Map<Order>(service));
        }
    }
}
