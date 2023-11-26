using SberCase.Models;
using System.Linq.Expressions;

namespace SberCase.Repositories.Interfaces
{
    public interface IBaseRepository<T, K> where T : IBaseModel<K>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(K id);
        Task<IEnumerable<T>> GetByConditionAsync(Func<T, bool> predicate);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
