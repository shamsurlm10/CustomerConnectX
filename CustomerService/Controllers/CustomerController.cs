using AutoMapper;
using CustomerService.Abstractions.BLL;
using CustomerService.Api.Controllers.Base;
using CustomerService.Models;
using CustomerService.Models.CustomerDto;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Api.Controllers
{
    public class CustomerController: BaseApiController
    {
        private readonly ICustomerManager _customerManager;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerManager customerManager, IMapper mapper)
        {
            _customerManager = customerManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CustomerListDto>>> GetAllCustomer()
        {
            var Customers = await _customerManager.GetAllAsync();
            var mapper = _mapper.Map<List<CustomerListDto>>(Customers);
            return Ok(mapper);
        }
        [HttpPost]
        public async Task<ActionResult> AddCustomer([FromBody] CustomerAddDto customer)
        {
            var mapper = _mapper.Map<Customer>(customer);
            var Customer = await _customerManager.AddAsync(mapper);
            return Ok(Customer);
        }
    }
}
