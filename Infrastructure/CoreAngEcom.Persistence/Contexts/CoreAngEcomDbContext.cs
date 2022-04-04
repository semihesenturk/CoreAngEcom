using CoreAngEcom.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAngEcom.Persistence.Contexts
{
    public class CoreAngEcomDbContext : DbContext
    {
        public CoreAngEcomDbContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}

