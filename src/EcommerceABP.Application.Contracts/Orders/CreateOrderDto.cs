using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceABP.Orders
{
    public class CreateOrderDto
    {
        public Guid CustomerId { get; set; }
        public List<CreateOrderItemDto> OrderItems { get; set; } = new();
    }
}
