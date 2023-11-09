using CustomerService.Abstractions.BLL;
using CustomerService.Abstractions.Repository;
using CustomerService.BLL.Base;
using CustomerService.Models;

namespace CustomerService.BLL
{
    public class ServiceManager : Manager<Service>, IServiceManager
    {
        private readonly IServiceRepository _serviceRepository;
        public ServiceManager(IServiceRepository repository) : base(repository)
        {
            _serviceRepository = repository;
        }
    }
}
