using AutoMapper;
using Common.Dtos;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ClientDto, Client>().ReverseMap();
            CreateMap<CommentDto, Comment>().ReverseMap();
            CreateMap<FruitDto, Fruit>().ReverseMap();
            CreateMap<TrayDto, Tray>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();

        }
    }
}
