
using Microsoft.EntityFrameworkCore;
using NTierExample.Dll.Repositories.Abstract;

namespace NTierExample.Dll.Repositories.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbContext _context = null!;
        protected readonly DbSet<T> dbSet = null!;

        protected BaseRepository(DbContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public virtual async Task<T?> SelectById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<List<T>> SelectAll()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> Insert(T entity)
        {
            var addedEntity = (await dbSet.AddAsync(entity)).Entity;
            await _context.SaveChangesAsync();
            return addedEntity;
        }

        public virtual async void Update(T entity)
        {
            dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            T? entity = dbSet.Find(id);
            if (entity != null)
            {
                _ = dbSet.Remove(entity).Entity;
                await _context.SaveChangesAsync();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
