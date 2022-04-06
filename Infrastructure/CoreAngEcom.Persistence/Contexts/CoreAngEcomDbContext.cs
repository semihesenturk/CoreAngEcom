using CoreAngEcom.Domain.Entities;
using CoreAngEcom.Domain.Entities.Common;
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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker
                 .Entries<BaseEntity>();

            foreach (var item in datas)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CretedDate = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdatedDate = DateTime.UtcNow,

                };
                item.Entity.IsActive = true;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}

