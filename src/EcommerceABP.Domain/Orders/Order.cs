using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace EcommerceABP.Orders
{
    public class Order : FullAuditedAggregateRoot<Guid>
    {
        public Guid CustomerId { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }
        public decimal TotalPrice { get; private set; }
        public OrderStatus Status { get; private set; }

        public void AddOrderItem(Guid productId, decimal price, int quantity)
        {
            if(quantity<=0)
                throw new BusinessException(EcommerceABPDomainErrorCodes.OrderQuantityMustBePositive);
            var isExistingItem = OrderItems.FirstOrDefault(i => i.ProductId == productId);
            if(isExistingItem == null)
                OrderItems.Add(new OrderItem(Guid.NewGuid(), Id, productId, price, quantity));
            else
                isExistingItem.increaseQuantity(quantity);

            var orderItem = new OrderItem(Guid.NewGuid(), Id, productId, price, quantity);
            CalculateTotalPrice();
        }  
        private void CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var item in OrderItems)
            {
                total += item.UnitPrice * item.Quantity;
            }
            TotalPrice = total;
        }
    }
}
