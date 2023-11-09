namespace CustomerService.Abstractions.BLL.Base
{
    public interface IManager<T> where T : class
    {
        Task<bool> AddAsync (T entity);
        Task<bool> AddAsync (List<T> entity);
        Task<IReadOnlyList<T>> GetAllAsync ();
        Task<T>FindByIdAsync (int id);
        Task<bool> RemoveAsync (T Entity);
        Task<bool>UpdateAsync (T Entity);
    }
}
