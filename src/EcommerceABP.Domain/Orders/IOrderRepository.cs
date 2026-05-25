using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace EcommerceABP.Orders
{
    public interface IOrderRepository: IRepository<Order, Guid>
    {
        Task<List<Order>> GetAllCustomerOrdersAsync(Guid customerId);
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderWithOrderItems(Guid id);
    }
}
