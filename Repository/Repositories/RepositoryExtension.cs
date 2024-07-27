using Microsoft.Extensions.DependencyInjection;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepository<Client>), typeof(ClientRepository));
            services.AddScoped(typeof(IRepository<Comment>), typeof(CommentRepository));
            services.AddScoped(typeof(IRepository<Order>), typeof(OrderRepository));
            services.AddScoped(typeof(IRepository<Tray>), typeof(TrayRepository));
            services.AddScoped(typeof(IRepository<Fruit>), typeof(FruitRepository));
            
            return services;
        }
    }
}
