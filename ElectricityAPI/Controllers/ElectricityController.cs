using ElectricityAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ElectricityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricityController : ControllerBase
    {
        private readonly IElectricityRepository _repo;
        private readonly ILogger<ElectricityController> _logger;

        public ElectricityController(IElectricityRepository repo, ILogger<ElectricityController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet("get-electricities")]
        public async Task<IActionResult> GetElectricities()
        {
            try
            {
                _logger.LogInformation($"Add Log, {nameof(GetElectricities)} - Method");
                var result = await _repo.GetElectricityData();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
