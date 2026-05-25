using EcommerceABP.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace EcommerceABP.Orders
{
    public interface IOrderAppService : IApplicationService
    {
        public Task<OrderDto> CreateOrderAsync(CreateOrderDto orderDto);
        public Task<List<OrderDto>> GetListAsync();
        public Task<OrderDto> GetOrderAsync(Guid id);
        
    }
}
