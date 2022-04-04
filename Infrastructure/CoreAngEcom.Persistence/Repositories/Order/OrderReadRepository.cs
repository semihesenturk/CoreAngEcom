using CoreAngEcom.Application.Repositories;
using CoreAngEcom.Domain.Entities;
using CoreAngEcom.Persistence.Contexts;

namespace CoreAngEcom.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(CoreAngEcomDbContext context) : base(context)
        {
        }
    }
}

