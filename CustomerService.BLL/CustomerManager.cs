using CustomerService.Abstractions.BLL;
using CustomerService.Abstractions.Repository;
using CustomerService.BLL.Base;
using CustomerService.Models;

namespace CustomerService.BLL
{
    public class CustomerManager : Manager<Customer>, ICustomerManager
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository repository) : base(repository)
        {
            _customerRepository = repository;
        }
    }
}
