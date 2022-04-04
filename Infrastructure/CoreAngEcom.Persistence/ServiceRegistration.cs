using CoreAngEcom.Application.Abstractions;
using CoreAngEcom.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace CoreAngEcom.Persistence
{
    public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
	}
}

