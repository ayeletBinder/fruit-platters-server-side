
using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;

namespace DataContext
{
    public class Db : DbContext, IContext
    {
        DbSet<Order> IContext.Orders { get ; set ; }
        DbSet<Client> IContext.Clients { get ; set ; }
        DbSet<Comment> IContext.Comments { get ; set ; }
        DbSet<Tray> IContext.Trays { get ; set ; }
        DbSet<Fruit> IContext.Fruits { get ; set ; }

        public async Task Save()
        {
            await SaveChangesAsync();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=FruitDB;trusted_connection=true");
        }
    }
}