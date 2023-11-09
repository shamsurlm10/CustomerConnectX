using CustomerService.Abstractions.BLL;
using CustomerService.Api.Controllers.Base;
using CustomerService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Api.Controllers
{
    public class ServiceController : BaseApiController
    {
        private readonly IServiceManager _serviceManager;

        public ServiceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<Service>>> GetAllServices()
        {
            var Services = await _serviceManager.GetAllAsync();
            return Ok(Services);
        }
    }
}
