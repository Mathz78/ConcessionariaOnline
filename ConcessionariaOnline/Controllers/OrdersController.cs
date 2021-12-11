using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOnline.Controllers
{
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private const string SUCCESS_MESSAGE = "Success.";

        private readonly IOrders _orders;

        public OrderController(IOrders orders)
        {
            _orders = orders;
        }

        /// <summary>
        /// Create a new order
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderRequest order)
        {
            var result = _orders.CreateOrder(order);
            
            if (result.Status == SUCCESS_MESSAGE)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}