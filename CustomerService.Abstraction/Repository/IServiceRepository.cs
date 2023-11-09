using CustomerService.Abstractions.Repository.Base;
using CustomerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Abstractions.Repository
{
    public interface IServiceRepository:IRepository<Service>
    {
    }
}
