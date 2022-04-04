using CoreAngEcom.Application.Repositories;
using CoreAngEcom.Domain.Entities;
using CoreAngEcom.Persistence.Contexts;

namespace CoreAngEcom.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(CoreAngEcomDbContext context) : base(context)
        {
        }
    }
}

