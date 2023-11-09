using CustomerService.Abstractions.Repository.Base;
using CustomerService.Models;

namespace CustomerService.Abstractions.Repository
{
    public interface ICustomerRepository: IRepository<Customer>
    {
    }
}
