using System.Linq.Expressions;

namespace BenMabelProject.Data.Repositories.Absraction
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T Entity);

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, Object>>[] includeProperties);

        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, Object>>[] includeProperties);

        Task<T> GetByIdAsync(int id);

        Task<T> UpdateAsync(T Entity);

        Task DeleteAsync(T Entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
    }
}
