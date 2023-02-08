using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : BaseApiController
    {
        public IOrderService OrderService { get; }

        public OrdersController(IOrderService orderService)
        {
            OrderService = orderService;
        }
        [HttpPost(nameof(CreateOrder))]
        public async Task<ActionResult<Orders>> CreateOrder(Orders orderDto)
        {
            var order = await OrderService.CreateOrderAsync(orderDto);
            if (order == null)
            {
                return BadRequest("Something went Wrong");
            }
            return Ok(order);

        }
    }
}
