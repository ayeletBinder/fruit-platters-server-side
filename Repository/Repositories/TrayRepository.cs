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
    public class TrayRepository : IRepository<Tray>
    {
        private readonly IContext context;
        public TrayRepository(IContext _context)
        {
            context = _context;
        }
        public async Task Add(Tray item)
        {
           await context.Trays.AddAsync(item);
           await context.Save();
        }

        public async Task<List<Tray>> GetAll()
        {
            return await this.context.Trays.ToListAsync();
        }

        public async Task<Tray> GetById(int id)
        {
            return await context.Trays.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Remove(int id)
        {
           context.Trays.Remove(await GetById(id));
           await context.Save();
        }

        public async Task Update(int id, Tray item)
        {
            Tray tray= context.Trays.FirstOrDefault(x => x.Id == id);
            tray.Size= item.Size;
            tray.Price= item.Price;
            tray.Fruits= item.Fruits;
            tray.NumHeart= item.NumHeart;
            tray.Comments= item.Comments;
            tray.Color= item.Color;
            tray.Order= item.Order;
            tray.Image= item.Image;
            await context.Save();
        }
    }
}
