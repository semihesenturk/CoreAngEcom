using CoreAngEcom.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CoreAngEcom.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}