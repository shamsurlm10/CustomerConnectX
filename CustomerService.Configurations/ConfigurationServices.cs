using CustomerService.Abstractions.BLL;
using CustomerService.Abstractions.Repository;
using CustomerService.ApplicationDbContext;
using CustomerService.BLL;
using CustomerService.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerService.Configurations
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddConfigurationService(this IServiceCollection services)
        {
            #region Customer
            services.AddScoped<ICustomerManager, CustomerManager>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            #endregion

            #region Service
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            #endregion

            #region DbContext
            services.AddScoped<DbContext, CustomerServiceDbContext>();
            #endregion

            return services;
        }
    }
}