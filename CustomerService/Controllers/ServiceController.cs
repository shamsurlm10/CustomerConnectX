using AutoMapper;
using CustomerService.Abstractions.BLL;
using CustomerService.Api.Controllers.Base;
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

        [HttpGet("all")]
        public async Task<ActionResult<ServiceListDto>> GetAllServices()
        {
            var Services = await _serviceManager.GetAllAsync();
            var mapper = _mapper.Map<List<ServiceListDto>>(Services);
            return Ok(mapper);
        }
        [HttpGet("by-service-id")]
        public async Task<ActionResult<ServiceListDto>> GetServiceById([FromQuery]int ServiceId)
        {
            var Service = await _serviceManager.FindByIdAsync(ServiceId);
            var mapper = _mapper.Map<ServiceListDto>(Service);
            return Ok(mapper);
        }
        [HttpPost("create")]
        public async Task<ActionResult> AddService([FromBody] ServiceAddDto service)
        {
            var mapper = _mapper.Map<Service>(service);
            var Service = await _serviceManager.AddAsync(mapper);
            return Ok(Service);
        }
        [HttpPut("update")]
        public async Task<ActionResult> UpdateService([FromBody] ServiceDeleteOrUpdateDto service)
        {
            var mapper = _mapper.Map<Service>(service);
            var UpdatedService = await _serviceManager.UpdateAsync(mapper);
            return Ok(UpdatedService);
        }
        [HttpDelete("remove")]
        public async Task<IActionResult> DeleteService([FromBody] ServiceDeleteOrUpdateDto service)
        {
            var mapper = _mapper.Map<Service>(service);
            var request = await _serviceManager.RemoveAsync(mapper);
            return Ok(request);
        }
    }
}
