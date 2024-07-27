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
    public class OrderRepository : IRepository<Order>
    {
        private readonly IContext context;
        public OrderRepository(IContext _context)
        {
            this.context = _context;
        }
        public async Task Add(Order item)
        {
            await context.Orders.AddAsync(item);
            await context.Save();
        }

        public async Task<List<Order>> GetAll()
        {
            return await context.Orders.ToListAsync();
        }

        public async Task<Order> GetById(int id)
        {
            return await context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Remove(int id)
        {
            context.Orders.Remove(await GetById(id));
            await context.Save();
        }

        public async Task Update(int id, Order item)
        {
            var order = this.context.Orders.FirstOrDefault(x => x.Id == id);
            order.ClientId = item.ClientId;
            //order.Payment = item.Payment;
            order.AddressToSend = item.AddressToSend;
            order.Treis = item.Treis;
            //order.PriceSum = item.PriceSum;
            order.IsCompleted = item.IsCompleted;
            order.OrderDate = item.OrderDate;
            order.ExecutionDate = item.ExecutionDate;
            await this.context.Save();
        }
    }
}
