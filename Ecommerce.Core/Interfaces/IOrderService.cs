using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Interfaces
{
    public interface IOrderService
    {
        Task<Orders> CreateOrderAsync(Orders order);
        Task<Orders> GetOrderByIdAsync(int orderId, string buyerEmail);
    }
}
