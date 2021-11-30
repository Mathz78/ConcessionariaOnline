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

        private readonly ConcessionariaOnlineContext _context;

        public Cars(ConcessionariaOnlineContext context)
        {
            _context = context;
        }

        public bool AddCar(Car car)
        {
            if (car.Price >= MINIMUM_PRICE) 
            {
                _context.Add(car);

                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IList<Car> GetAllCars()
        {
            var cars = _context.Cars.ToList();

            return cars;
        }
    }
}