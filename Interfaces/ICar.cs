using System.Collections.Generic;
using ConcessionariaOnline.Models;

namespace ConcessionariaOnline.Interfaces
{
    public interface ICar
    {
        /// <summary>
        /// Creates a new car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public bool AddCar(Car car);

        /// <summary>
        /// Return a list of all cars
        /// </summary>
        /// <returns></returns>
        public IList<Car> GetAllCars();
    }
}