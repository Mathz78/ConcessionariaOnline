using System;
using System.Linq;
using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using ConcessionariaOnline.Models.ConcessionariaOnlineContext;

namespace ConcessionariaOnline.Facades
{
    public class Orders : IOrders
    {
        private readonly ConcessionariaOnlineContext _context;

        public Orders(ConcessionariaOnlineContext context)
        {
            _context = context;
        }

        public OrderReponse CreateOrder(OrderRequest order)
        {
            var car = _context.Cars.FirstOrDefault(carro => carro.Id == order.carId);

            if (car.Sold)
            {
                return new OrderReponse 
                {
                    Message = "Car was sold.",
                    OrderDate = null,
                    Price = car.Price,
                    Status = "Failure."
                };
            }
            else
            {
                SellCar(car, order.clientId);

                return new OrderReponse 
                {
                    Message = "Congratulations! You got a new car.",
                    OrderDate = DateTime.Now,
                    Price = car.Price,
                    Status = "Success."
                };
            }
        }

        private void SellCar(Car car, int clientId)
        {
            car.clientId = clientId;
            car.Sold = true;

            _context.SaveChanges();
        }
    }
}