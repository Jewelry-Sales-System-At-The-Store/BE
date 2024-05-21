
using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JewelryController : ControllerBase
    {
        private readonly IJewelryService _jewelryService;
        private readonly IMapper _mapper;
        public JewelryController(IJewelryService jewelryService, IMapper mapper)
        {
            _jewelryService = jewelryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetJewelries()
        {
            var jewelries = await _jewelryService.GetJewelries();
            return Ok(jewelries);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJewelryById(int id)
        {
            var jewelry = await _jewelryService.GetJewelryById(id);
            return Ok(jewelry);
        }
        [HttpPost]
        public async Task<IActionResult> CreateJewelry(JewelryDTO jewelryDTO)
        {
            var jewelyEntity = _mapper.Map<Jewelry>(jewelryDTO);
            var result = await _jewelryService.CreateJewelry(jewelyEntity);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateJewelry(Jewelry jewelry)
        {
            var result = await _jewelryService.UpdateJewelry(jewelry);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJewelry(int id)
        {
            var result = await _jewelryService.DeleteJewelry(id);
            return Ok(result);
        }
    }
}
