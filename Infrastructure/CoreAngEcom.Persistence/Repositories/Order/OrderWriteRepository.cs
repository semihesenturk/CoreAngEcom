using CoreAngEcom.Application.Repositories;
using CoreAngEcom.Domain.Entities;
using CoreAngEcom.Persistence.Contexts;

namespace CoreAngEcom.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(CoreAngEcomDbContext context) : base(context)
        {
        }
    }
}

