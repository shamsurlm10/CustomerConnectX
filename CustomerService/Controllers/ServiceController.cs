using AutoMapper;
using CustomerService.Abstractions.BLL;
using CustomerService.Api.Controllers.Base;
using CustomerService.BLL;
using CustomerService.Models;
using CustomerService.Models.ServiceDto;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Api.Controllers
{
    public class ServiceController : BaseApiController
    {
        private readonly IServiceManager _serviceManager;
        private readonly IMapper _mapper;

        public ServiceController(IServiceManager serviceManager, IMapper mapper)
        {
            _serviceManager = serviceManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceListDto>> GetAllServices()
        {
            var Services = await _serviceManager.GetAllAsync();
            var mapper = _mapper.Map<List<ServiceListDto>>(Services);
            return Ok(mapper);
        }
        [HttpPost]
        public async Task<ActionResult> AddService([FromBody] ServiceAddDto service)
        {
            var mapper = _mapper.Map<Service>(service);
            var Service = await _serviceManager.AddAsync(mapper);
            return Ok(Service);
        }
    }
}
