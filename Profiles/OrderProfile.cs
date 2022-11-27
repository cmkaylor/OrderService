using AutoMapper;
using OrderService.Dtos;
using OrderService.Models;

namespace OrderService.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            // Source -> Target
            CreateMap<OrderCreateDto, Order>();
            CreateMap<Order, OrderDto>();
        }
    }
}