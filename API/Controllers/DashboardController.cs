using Microsoft.AspNetCore.Mvc;
using Services.Implementation;
using Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet("TotalRevenueAllTime")]
        public async Task<IActionResult> GetTotalRevenueAllTime()
        {
            var totalRevenue = await _dashboardService.GetTotalRevenueAllTime();
            return Ok(totalRevenue);
        }

        [HttpGet("GetTotalRevenue")]
        public async Task<IActionResult> GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            var result = await _dashboardService.GetTotalRevenue(startDate, endDate);
            return Ok(result);
        }

        [HttpGet("GetRevenueByCounter")]
        public async Task<IActionResult> GetRevenueByCounter(string counterId)
        {
            var result = await _dashboardService.GetRevenueByCounter(counterId);
            return Ok(result);
        }

        [HttpGet("GetRevenueByEmployee")]
        public async Task<IActionResult> GetRevenueByEmployee(string userId)
        {
            var result = await _dashboardService.GetRevenueByEmployee(userId);
            return Ok(result);
        }

        [HttpGet("GetRevenueByProductType")]
        public async Task<IActionResult> GetRevenueByProductType(string typeId)
        {
            var result = await _dashboardService.GetRevenueByProductType(typeId);
            return Ok(result);
        }

        [HttpGet("TotalCustomers")]
        public async Task<IActionResult> GetTotalCustomers()
        {
            var totalCustomers = await _dashboardService.GetTotalCustomers();
            return Ok(totalCustomers);
        }

        [HttpGet("NewCustomers")]
        public async Task<IActionResult> GetNewCustomers([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var newCustomers = await _dashboardService.GetNewCustomers(startDate, endDate);
            return Ok(newCustomers);
        }

        [HttpGet("RepeatCustomers")]
        public async Task<IActionResult> GetRepeatCustomers()
        {
            var repeatCustomers = await _dashboardService.GetRepeatCustomers();
            return Ok(repeatCustomers);
        }

        [HttpGet("ActiveCustomers")]
        public async Task<IActionResult> GetActiveCustomers([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var activeCustomers = await _dashboardService.GetActiveCustomers(startDate, endDate);
            return Ok(activeCustomers);
        }

        [HttpGet("BestSellingJewelry")]
        public async Task<IActionResult> GetBestSellingProducts()
        {
            var bestSellingProducts = await _dashboardService.GetBestSellingProducts();
            return Ok(bestSellingProducts);
        }

        [HttpGet("BestSellingJewelryTypes")]
        public async Task<IActionResult> GetBestSellingProductTypes()
        {
            var bestSellingProductTypes = await _dashboardService.GetBestSellingProductTypes();
            return Ok(bestSellingProductTypes);
        }

        [HttpGet("TotalRevenueByJewelry")]
        public async Task<IActionResult> GetTotalRevenueByProducts()
        {
            var totalRevenueByProducts = await _dashboardService.GetTotalRevenueByProducts();
            return Ok(totalRevenueByProducts);
        }

        [HttpGet("TotalRevenueByJewelryTypes")]
        public async Task<IActionResult> GetTotalRevenueByProductTypes()
        {
            var totalRevenueByProductTypes = await _dashboardService.GetTotalRevenueByProductTypes();
            return Ok(totalRevenueByProductTypes);
        }
    }
}
