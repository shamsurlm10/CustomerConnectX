using AutoMapper;
using CustomerService.Abstractions.BLL;
using CustomerService.Api.Controllers.Base;
using CustomerService.Models;
using CustomerService.Models.CustomerDto;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Api.Controllers
{

    public class CustomerController : BaseApiController
    {
        private readonly ICustomerManager _customerManager;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerManager customerManager, IMapper mapper)
        {
            _customerManager = customerManager;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<CustomerListDto>>> GetAllCustomer()
        {
            var Customers = await _customerManager.GetAllAsync();
            var mapper = _mapper.Map<List<CustomerListDto>>(Customers);
            return Ok(mapper);
        }

        [HttpGet("{by-customer-id}/services")]
        public async Task<ActionResult<CustomerListWithServiceDto>> GetCustomerById([FromQuery]int CustomerId)
        {
            var Customer = await _customerManager.FindByIdAsync(CustomerId);
            var mapper = _mapper.Map<CustomerListWithServiceDto>(Customer);
            return Ok(mapper);
        }
        [HttpPost("create")]
        public async Task<ActionResult> AddCustomer([FromBody] CustomerAddDto customer)
        {
            var mapper = _mapper.Map<Customer>(customer);
            var Customer = await _customerManager.AddAsync(mapper);
            return Ok(Customer);
        }
        [HttpPut("update")]
        public async Task<ActionResult> UpdateCustomer([FromBody] CustomerDeleteOrUpdateDto customer)
        {
            var mapper = _mapper.Map<Customer>(customer);
            var UpdatingCustomer = await _customerManager.UpdateAsync(mapper);
            return Ok(UpdatingCustomer);
        }
        [HttpDelete("remove")]
        public async Task<IActionResult> DeleteCustomer([FromBody] CustomerDeleteOrUpdateDto customer)
        {
            var mapper = _mapper.Map<Customer>(customer);
            var request = await _customerManager.RemoveAsync(mapper);
            return Ok(request);
        }
    }
}
