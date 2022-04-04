using System.Linq.Expressions;
using CoreAngEcom.Application.Repositories;
using CoreAngEcom.Domain.Entities.Common;
using CoreAngEcom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CoreAngEcom.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {

        private readonly CoreAngEcomDbContext _context;

        public ReadRepository(CoreAngEcomDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
            => Table.Where(expression);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
            => await Table.FirstOrDefaultAsync(expression);

        public async Task<T> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(m => m.Id == Guid.Parse(id));
    }
}

