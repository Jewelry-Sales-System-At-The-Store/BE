using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarrantyController(IWarrantyService warrantyService) : ControllerBase
    {
        public IWarrantyService WarrantyService { get; } = warrantyService;
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var warranties = await WarrantyService.GetWarranties();
            return Ok(warranties);
        }
    }
}
