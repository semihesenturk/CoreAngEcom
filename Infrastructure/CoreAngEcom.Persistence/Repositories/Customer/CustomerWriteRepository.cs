using CoreAngEcom.Application.Repositories;
using CoreAngEcom.Domain.Entities;
using CoreAngEcom.Persistence.Contexts;

namespace CoreAngEcom.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(CoreAngEcomDbContext context) : base(context)
        {
        }
    }
}

