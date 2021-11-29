using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOnline.Controllers
{
    [Route("api/car")]
    public class CarsController : ControllerBase
    {
        private readonly ICar _car;

        public CarsController(ICar car)
        {
            _car = car;
        }

        /// <summary>
        /// Create a new order
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateOrder([FromBody] Car car)
        {
            var result = _car.AddCar(car);
            
            if (result)
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