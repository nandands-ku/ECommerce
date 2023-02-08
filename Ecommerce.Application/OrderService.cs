using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Orders> CreateOrderAsync(Orders order)
        {
            var subTotal = order.OrderItems.Sum(i => i.Price * i.Quantity);
            order.SubTotal = subTotal;

            _unitOfWork.repository<Orders>().Add(order);
            var result = await _unitOfWork.Complete();
            if (result <= 0)
            {
                return null;
            }
            return order;
        }

        public Task<Orders> GetOrderByIdAsync(int orderId, string buyerEmail)
        {
            throw new NotImplementedException();
        }
    }
}
