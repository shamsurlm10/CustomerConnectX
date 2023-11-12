using CustomerService.Abstractions.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Repositories.Base
{
    public abstract class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _db;
        public EfRepository(DbContext db) 
        {
            _db = db;
        }
        public async Task<bool> AddAsync(T Entity)
        {
            _db.Set<T>().AddAsync(Entity);
            return await _db.SaveChangesAsync()>0;
        }

        public async Task<bool> AddAsync(List<T> Entities)
        {
            _db.Set<T>().AddRange(Entities);
            return await _db.SaveChangesAsync()>0;
        }

        public virtual async Task<T> FindByIdAsync(int Id)
        {
            return await _db.Set<T>().FindAsync(Id);
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _db.Set<T>().AsNoTracking().ToListAsync();
        }
        public async Task<bool> RemoveAsync(T Entity)
        {
            _db.Set<T>().Remove(Entity);
            return await _db.SaveChangesAsync()> 0;
        }

        public async Task<bool> UpdateAsync(T Entity)
        {
            _db.Entry(Entity).State = EntityState.Modified;
            return await _db.SaveChangesAsync()>0;
        }
    }
}
