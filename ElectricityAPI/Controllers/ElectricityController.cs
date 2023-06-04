using ElectricityAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricityController : ControllerBase
    {
        private readonly IElectricityRepository _repo;

        public ElectricityController(IElectricityRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("get-electricities")]
        public async Task<IActionResult> GetElectricities()
        {
            try
            {
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
