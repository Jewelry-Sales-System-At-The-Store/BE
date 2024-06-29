using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RevenueDashboardController : ControllerBase
    {
        private readonly IRevenueService _revenueService;

        public RevenueDashboardController(IRevenueService revenueService)
        {
            _revenueService = revenueService;
        }

        [HttpGet("GetTotalRevenue")]
        public async Task<IActionResult> GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            var result = await _revenueService.GetTotalRevenue(startDate, endDate);
            return Ok(result);
        }

        [HttpGet("GetRevenueByCounter")]
        public async Task<IActionResult> GetRevenueByCounter(string counterId)
        {
            var result = await _revenueService.GetRevenueByCounter(counterId);
            return Ok(result);
        }

        [HttpGet("GetRevenueByEmployee")]
        public async Task<IActionResult> GetRevenueByEmployee(string userId)
        {
            var result = await _revenueService.GetRevenueByEmployee(userId);
            return Ok(result);
        }

        [HttpGet("bGetRevenueByProductType")]
        public async Task<IActionResult> GetRevenueByProductType(string typeId)
        {
            var result = await _revenueService.GetRevenueByProductType(typeId);
            return Ok(result);
        }
    }
}
