using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ClientRepository:  IRepository<Client>
    {
            private readonly IContext context;
            public ClientRepository(IContext _context)
            {
                this.context = _context;
            }

            public async Task Add(Client item)
            {
               await this.context.Clients.AddAsync(item);
               await this.context.Save();
            }
            public async Task<List<Client>> GetAll()
            {
                return await this.context.Clients.ToListAsync();
            }

            public async Task<Client> GetById(int id)
            {

                return await context.Clients.FirstOrDefaultAsync(x => x.Id == id);
            }



        public async Task Remove(int id)
        {
            context.Clients.Remove(await GetById(id));
            await context.Save();
        }

        public async Task Update(int id, Client item)
            {
                var client = this.context.Clients.FirstOrDefault(x => x.Id == id);
                client.Tz= item.Tz;
                client.FirstName = item.FirstName;
                client.LastName = item.LastName;
                client.Email = item.Email;
                client.Address = item.Address;
                client.Phone = item.Phone;
                client.Password = item.Password;
                client.Orders = item.Orders;
                await this.context.Save();
            }
        }
}
