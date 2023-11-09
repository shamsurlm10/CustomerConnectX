using CustomerService.Abstractions.BLL.Base;
using CustomerService.Abstractions.Repository.Base;

namespace CustomerService.BLL.Base
{
    public abstract class Manager<T> : IManager<T> where T : class
    {
        private readonly IRepository<T> _repository;
        public Manager(IRepository<T> repository)
        {
            _repository=repository;
        }
        public async Task<bool> AddAsync(T entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<bool> AddAsync(List<T> entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _repository.FindByIdAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<bool> RemoveAsync(T Entity)
        {
            return await _repository.RemoveAsync(Entity);
        }

        public async Task<bool> UpdateAsync(T Entity)
        {
            return await _repository.UpdateAsync(Entity);
        }
    }
}
