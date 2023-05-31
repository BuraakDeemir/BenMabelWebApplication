using BenMabelProject.Data.Context;
using BenMabelProject.Data.Repositories.Absraction;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BenMabelProject.Data.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, Object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }

        public async Task AddAsync(T Entity)
        {
            await Table.AddAsync(Entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.SingleAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T Entity)
        {
            await Task.Run(() => Table.Update(Entity));
            return Entity;
        }

        public async Task DeleteAsync(T Entity)
        {
            await Task.Run(() => Table.Remove(Entity));
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate);
        }
    }
}
