using Common.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using static Service.MapperProfile;
namespace Service.Services
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddRepository();
            services.AddScoped(typeof(IService<ClientDto>), typeof(ClientService));
            services.AddScoped(typeof(IService<CommentDto>), typeof(CommentService));
            services.AddScoped(typeof(IService<OrderDto>), typeof(OrderService));
            services.AddScoped(typeof(IService<TrayDto>), typeof(TrayService));
            services.AddScoped(typeof(IService<FruitDto>), typeof(FruitService));
            services.AddAutoMapper(typeof(MapperProfile));
            return services;

        }
}
}
