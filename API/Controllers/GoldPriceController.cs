using BusinessObjects.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Tools;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoldPriceController(IGoldPriceService goldPriceService) : ControllerBase
    {
        private IGoldPriceService GoldPriceService { get; } = goldPriceService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var goldPrices = await GoldPriceService.GetGoldPrices();
            return Ok(goldPrices);
        }
    }
}
