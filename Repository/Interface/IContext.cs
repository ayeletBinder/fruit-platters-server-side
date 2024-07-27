using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IContext
    {
            public DbSet<Order> Orders { get; set; }
            public DbSet<Client> Clients { get; set; }
            public DbSet<Comment> Comments { get; set; }
            public DbSet<Tray> Trays { get; set; }
            public DbSet<Fruit> Fruits { get; set; }
            public Task Save();
    }
}
