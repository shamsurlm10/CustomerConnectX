using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Abstractions.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        Task<bool> AddAsync(T Entity);
        Task<bool> AddAsync(List<T> Entity);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> FindByIdAsync(int Id);
        Task<bool>RemoveAsync(T Entity);
        Task<bool> UpdateAsync(T Entity);
    }
}
