using EcommerceABP.Products;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace EcommerceABP.Orders
{
    public class OrderItem : Entity<Guid>
    {
        public Guid OrderId { get;  set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public decimal TotalPrice => UnitPrice * Quantity;
        public OrderItem(Guid id, Guid orderId, Guid productId, decimal unitPrice, int quantity) : base(id)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        internal void increaseQuantity(int quantity)
        {
            Quantity += quantity;
        }
    }
}
