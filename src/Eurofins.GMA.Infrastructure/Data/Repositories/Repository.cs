using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Domain.Repositories;
using Eurofins.GMA.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Eurofins.GMA.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SqlDbContext DbContext;

        public Repository(SqlDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (typeof(IAuditEntity).IsAssignableFrom(typeof(TEntity)))
            {
                ((IAuditEntity)entity).CreatedDate = DateTime.UtcNow;
            }
            DbContext.Set<TEntity>().Add(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            if (typeof(IDeleteEntity).IsAssignableFrom(typeof(TEntity)))
            {
                ((IDeleteEntity)entity).IsDeleted = true;
                DbContext.Set<TEntity>().Update(entity);
            }
            else
            {
                DbContext.Set<TEntity>().Remove(entity);
            }
            await DbContext.SaveChangesAsync();
        }

        public async Task<IQueryable<TEntity>> List(Expression<Func<TEntity, bool>> expression)
        {
            return await Task.FromResult(DbContext.Set<TEntity>().Where(expression));
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await DbContext.Set<TEntity>().FirstOrDefaultAsync(expression);
        }
    }
}
