using CustomerService.Abstractions.Repository;
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
        public CustomerRepository(DbContext db) : base(db)
        {
        }
    }
}
