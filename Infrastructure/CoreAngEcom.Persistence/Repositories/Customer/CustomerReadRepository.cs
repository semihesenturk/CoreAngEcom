using CoreAngEcom.Application.Repositories;
using CoreAngEcom.Domain.Entities;
using CoreAngEcom.Persistence.Contexts;

namespace CoreAngEcom.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(CoreAngEcomDbContext context) : base(context)
        {
        }
    }
}

