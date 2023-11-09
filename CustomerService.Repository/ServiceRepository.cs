using CustomerService.Abstractions.Repository;
using CustomerService.Models;
using CustomerService.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Repositories
{
    public class ServiceRepository : EfRepository<Service>, IServiceRepository
    {
        public ServiceRepository(DbContext db) : base(db)
        {
        }
    }
}
