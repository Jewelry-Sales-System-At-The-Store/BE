using BusinessObjects.DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController(IPromotionService promotionService) : ControllerBase
    {
        private IPromotionService PromotionService { get; } = promotionService;
        [HttpGet("GetPromotions")]
        public async Task<IActionResult> GetAllPromotion()
        {
            var result = await PromotionService.GetPromotions();
            return Ok(result);
        }
        [HttpGet("GetPromotionById/{id}")]
        public async Task<IActionResult> GetPromotionById(string id)
        {
            var result = await PromotionService.GetPromotionById(id);
            return Ok(result);
        }
        [HttpPost("AddNewPromotion")]
        public async Task<IActionResult> AddPromotion(PromotionDto promotionDto)
        {
            var result = await PromotionService.CreatePromotion(promotionDto);
            return Ok(result);
        }
        [HttpDelete("DeletePromotion")]
        public async Task<IActionResult> DeletePromotion(string id)
        {
            var result = await PromotionService.DeletePromotion(id);
            return Ok(result);
        }

        [HttpPut("UpdatePromotion")]
        public async Task<IActionResult> UpdatePromotion(string id, PromotionDto promotionDto)
        {
            var result = await PromotionService.UpdatePromotion(id, promotionDto);
            return Ok(result);
        }
    }
}
