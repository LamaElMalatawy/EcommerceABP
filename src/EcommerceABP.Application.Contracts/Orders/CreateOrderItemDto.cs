using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EcommerceABP.Products
{
    public class CreateOrderItemDto : EntityDto<Guid>
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } = 0;
        public decimal Price { get; set; }

    }
}
