using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ServiceRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _servicesRepository;

        public ServicesController(IServiceRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetServiceList() 
        {
            var value = await _servicesRepository.GetAllServiceAsync();
            return Ok(value);
        }
    }
}
