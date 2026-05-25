using AutoMapper;
using EcommerceABP.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceABP.Mappings
{
    public class OrderMappingProfile: Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderDto>()
            .ForMember(dest => dest.TotalPrice,
                opt => opt.MapFrom(src => src.TotalPrice))
            .ForMember(dest => dest.Status,
                opt => opt.MapFrom(src => src.Status.ToString()));

            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(dest => dest.UnitPrice,
                    opt => opt.MapFrom(src => src.UnitPrice));
        }
    }
}
