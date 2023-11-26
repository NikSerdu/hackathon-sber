using Microsoft.EntityFrameworkCore;
using SberCase.Data;
using SberCase.Models;
using SberCase.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SberCase.Repositories.Impls
{
    public class BaseRepository<T, K> : IBaseRepository<T, K> where T : class, IBaseModel<K>
    {
        protected readonly DatabaseContext _context;
        public BaseRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync() =>
            await _context.Set<T>().ToListAsync();

        public async Task<IEnumerable<T>> GetByConditionAsync(Func<T, bool> predicate) =>
            await Task.Run(() => _context.Set<T>().Where(predicate));

        public async Task<T?> GetByIdAsync(K id) =>
            await _context.Set<T>().FindAsync(id);

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
