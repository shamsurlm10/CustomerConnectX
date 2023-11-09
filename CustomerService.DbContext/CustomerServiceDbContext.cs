using CustomerService.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.ApplicationDbContext
{
    public class CustomerServiceDbContext : DbContext
    {
        public CustomerServiceDbContext(DbContextOptions<CustomerServiceDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
