using CoreAngEcom.Domain.Entities.Common;

namespace CoreAngEcom.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);

        Task<bool> AddRangeAsync(List<T> datas);

        bool Update(T model);

        bool Remove(T model);

        Task<bool> RemoveAsync(string id);

        bool RemoveRange(List<T> datas);

        Task<int> SaveAsync();
    }
}