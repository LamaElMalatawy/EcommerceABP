using EcommerceABP.Orders;
using EcommerceABP.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace EcommerceABP.Orders
{
    public class OrderAppService : ApplicationService, IOrderAppService
    {
        private readonly IRepository<Order, Guid> _orderRepository;

        public OrderAppService(IRepository<Order, Guid> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        //[Authorize(EcommerceABPPermissions.CreateOrderPermission)]
        public async Task<OrderDto> CreateOrderAsync(CreateOrderDto orderDto)
        {
            var order = new Order(GuidGenerator.Create(), orderDto.CustomerId);

            foreach(var orderItem in orderDto.OrderItems)
            {
                order.AddOrderItem(orderItem.ProductId, orderItem.Price, orderItem.Quantity);
            }

            await _orderRepository.InsertAsync(order);
            return ObjectMapper.Map<Order, OrderDto>(order);

        }

        //[Authorize(EcommerceABPPermissions.ViewOrderPermission)]
        public async Task<List<OrderDto>> GetListAsync()
        {
            var queryable = await _orderRepository.WithDetailsAsync(o => o.OrderItems);
            var orders = await AsyncExecuter.ToListAsync(queryable);
            return ObjectMapper.Map<List<Order>, List<OrderDto>>(orders);
        }

        //[Authorize(EcommerceABPPermissions.ViewOrderPermission)]
        public async Task<OrderDto> GetOrderAsync(Guid id)
        {
            var queryable = await _orderRepository.WithDetailsAsync(o => o.OrderItems);
            var order = await AsyncExecuter.FirstOrDefaultAsync(queryable, o => o.Id == id);

            if(order == null)
            {
                throw new BusinessException(EcommerceABPDomainErrorCodes.OrderNotFound).WithData("Id", id);
            }
            return ObjectMapper.Map<Order, OrderDto>(order);
        }
    }
}
