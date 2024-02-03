using AutoMapper;
using DataAcces.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CarDTO, Car>();
            CreateMap<Car, CarDTO>();
            CreateMap<CarImage, CarImageDTO>().ReverseMap();
            CreateMap<CarFeature, CarFeatureDTO>().ReverseMap();
            CreateMap<OrderDTO, Order>().ReverseMap().ForMember(orderDTO => orderDTO.CarDTO, o => o.MapFrom(order => order.Car));
         // CreateMap<Order, OrderDTO>().ReverseMap().ForMember(order => order.Car, o => o.MapFrom(orderDTO => orderDTO.CarDTO));
        }
    }
}
