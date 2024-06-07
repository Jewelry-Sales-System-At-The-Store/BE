using BusinessObjects.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Implementation;
using Services.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController(IPromotionService promotionService) : ControllerBase
    {
        public IPromotionService PromotionService { get; } = promotionService;
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllPromotion()
        {
            var result = await PromotionService.GetPromotions();
            return Ok(result);
        }

        [HttpPost("AddNewPromotion")]
        public async Task<IActionResult> AddPromotion(PromotionDto promotionDto)
        {
            var result = await PromotionService.CreatePromotion(promotionDto);
            return Ok(result);
        }
        [HttpDelete("DeletePromotion")]
        public async Task<IActionResult> DeletePromotion(int id)
        {
            var result = await PromotionService.DeletePromotion(id);
            return Ok(result);
        }

        [HttpPut("UpdatePromotion")]
        public async Task<IActionResult> UpdatePromotion(int id, PromotionDto promotionDto)
        {
            var result = await PromotionService.UpdatePromotion(id, promotionDto);
            return Ok(result);
        }
    }
}
