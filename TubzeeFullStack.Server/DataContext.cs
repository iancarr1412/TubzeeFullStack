using Microsoft.EntityFrameworkCore;


namespace TubzeeFullStack.Server
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Town> Town { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
    }
}
