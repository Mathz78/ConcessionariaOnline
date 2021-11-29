using Microsoft.EntityFrameworkCore;

namespace ConcessionariaOnline.Models.ConcessionariaOnlineContext
{
    public class ConcessionariaOnlineContext : DbContext
    {
        public ConcessionariaOnlineContext(DbContextOptions<ConcessionariaOnlineContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}