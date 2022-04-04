using CoreAngEcom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CoreAngEcom.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CoreAngEcomDbContext>
    {
        public CoreAngEcomDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CoreAngEcomDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);

            return new(dbContextOptionsBuilder.Options);
        }
    }
}

