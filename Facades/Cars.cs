using ConcessionariaOnline.Models.ConcessionariaOnlineContext;
using ConcessionariaOnline.Models;
using ConcessionariaOnline.Interfaces;

namespace ConcessionariaOnline.Facades
{
    public class Cars : ICar
    {
        private readonly ConcessionariaOnlineContext _context;

        public Cars(ConcessionariaOnlineContext context)
        {
            _context = context;
        }

        public bool AddCar(Car car)
        {
            _context.Add(car);

            _context.SaveChanges();
            return true;
        }
    }
}