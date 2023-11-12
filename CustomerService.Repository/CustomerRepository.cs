using CustomerService.Abstractions.Repository;
using CustomerService.ApplicationDbContext;
using CustomerService.Models;
using CustomerService.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Repositories
{
    public class CustomerRepository : EfRepository<Customer>, ICustomerRepository
    {
        private readonly CustomerServiceDbContext _db;
        public CustomerRepository(CustomerServiceDbContext db) : base(db)
        {
            _db = db;
        }
        public override async Task<Customer> FindByIdAsync(int id)
        {
            return await _db.Customers.Include(c=>c.Services).Where(x => x.CustomerId == id).FirstOrDefaultAsync();
        }
    }
}
