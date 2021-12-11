using ConcessionariaOnline.Models.ConcessionariaOnlineContext;
using ConcessionariaOnline.Models;
using ConcessionariaOnline.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ConcessionariaOnline.Facades
{
    public class Cars : ICar
    {
        private const int MINIMUM_PRICE = 0;
        private const string SUCCESS_MESSAGE = "Success.";
        private const string FAILURE_MESSAGE = "Failure.";

        private readonly ConcessionariaOnlineContext _context;

        public Cars(ConcessionariaOnlineContext context)
        {
            _context = context;
        }

        public UserResponse AddCar(Car car)
        {
            if (car.Price >= MINIMUM_PRICE) 
            {
                _context.Add(car);

                _context.SaveChanges();
                
                return new UserResponse
                {
                    Message = "The car was added.",
                    Status = SUCCESS_MESSAGE
                };
            }
            else
            {
                return new UserResponse
                {
                    Message = "The car was not added.",
                    Status = FAILURE_MESSAGE
                };
            }
        }

        public IList<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }
    }
}