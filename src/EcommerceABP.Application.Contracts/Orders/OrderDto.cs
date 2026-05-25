using EcommerceABP.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EcommerceABP.Orders
{
    public class OrderDto : AuditedEntityDto<Guid>
    {
        public Guid CustomerId { get; set; }
        public decimal TotalPrice { get; set; } 
        public OrderStatus Status { get; set; }
        public List<OrderItemDto> OrderItems { get; set; } = new();
    }
}
