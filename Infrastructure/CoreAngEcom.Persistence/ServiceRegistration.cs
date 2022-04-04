using CoreAngEcom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoreAngEcom.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CoreAngEcomDbContext>
                (options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}

