using Microsoft.EntityFrameworkCore;

namespace ConcessionariaOnline.Models.ConcessionariaOnlineContext
{
    public class ConcessionariaOnlineContext : DbContext
    {
        public ConcessionariaOnlineContext(DbContextOptions<ConcessionariaOnlineContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}