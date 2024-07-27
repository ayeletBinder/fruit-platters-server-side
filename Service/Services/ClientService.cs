using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Dtos;
using Repository.Interface;
using AutoMapper;
using Repository.Entity;

namespace Service.Services
{
    public class ClientService : IService<ClientDto>
    {
        private readonly IRepository<Client> repository;
        private readonly IMapper mapper;
        public ClientService(IRepository<Client> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task Add(ClientDto service)
        {
            await this.repository.Add(mapper.Map<Client>(service));
        }

        public async Task Delete(int id)
        {
           await repository.Remove(id);
        }

        public async Task<List<ClientDto>> GetAll()
        {
            return  mapper.Map<List<ClientDto>>(await repository.GetAll());
        }

        public async Task<ClientDto> GetById(int id)
        {
            return  mapper.Map<ClientDto>(await repository.GetById(id));
        }

        public async Task Update(int id, ClientDto service)
        {
            await repository.Update(id, mapper.Map<Client>(service));
        }
    }
}
