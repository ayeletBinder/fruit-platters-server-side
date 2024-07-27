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
    public class TrayService : IService<TrayDto>
    {
        private readonly IRepository<Tray> repository;
        private readonly IMapper mapper;
        public TrayService(IRepository<Tray> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task Add(TrayDto service)
        {
            await repository.Add(mapper.Map<Tray>(service));
        }

        public async Task Delete(int id)
        {
            await repository.Remove(id);
        }

        public async Task<List<TrayDto>> GetAll()
        {
            return mapper.Map<List<TrayDto>>(await repository.GetAll());
        }

        public async Task<TrayDto> GetById(int id)
        {
            return mapper.Map<TrayDto>(await repository.GetById(id));
        }

        public async Task Update(int id, TrayDto service)
        {
            await repository.Update(id, mapper.Map<Tray>(service));
        }
    }
}
