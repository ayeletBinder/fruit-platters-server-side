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
    public class FruitRepository: IRepository<Fruit>
    {
        private readonly IContext context;
        public FruitRepository(IContext _context)
        {
            this.context = _context;
        }
        public async Task Add(Fruit fruit)
        {
            await context.Fruits.AddAsync(fruit);
            await context.Save();
        }
        public async Task Update(int id, Fruit fruit)
        {
            Fruit f = context.Fruits.FirstOrDefault(x => x.Id == id);
            f.Name = fruit.Name;
            f.IsExists = fruit.IsExists;
            f.Color = fruit.Color;
            //f.IsAdditionalCharge = fruit.IsAdditionalCharge;
            f.Trays= fruit.Trays;
            f.SomeAdditional = fruit.SomeAdditional;
            await context.Save();
        }


        public async Task<List<Fruit>> GetAll()
        {
            return await context.Fruits.ToListAsync();
        }

        public async Task<Fruit> GetById(int id)
        {
            return await context.Fruits.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Remove(int id)
        {
            context.Fruits.Remove(await GetById(id));
           await context.Save();
        }

    }
}