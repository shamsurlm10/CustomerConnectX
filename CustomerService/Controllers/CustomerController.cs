using CustomerService.Abstractions.BLL;
using CustomerService.Api.Controllers.Base;
using CustomerService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Api.Controllers
{
    public class CustomerController: BaseApiController
    {
        private readonly ICustomerManager _customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomer()
        {
            var Customers = await _customerManager.GetAllAsync();
            return Ok(Customers);
        }
    }
}
