
using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interface;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JewelryController(IJewelryService jewelryService, IMapper mapper) : ControllerBase
{
    private IJewelryService JewelryService { get; } = jewelryService;
    private IMapper Mapper { get; } = mapper;

    [HttpGet("GetJewelries")]
    public async Task<IActionResult> GetJewelries()
    {
        var jewelries = await JewelryService.GetJewelries();
        return Ok(jewelries);
    }
    [HttpGet("GetJewelryById/{id}")]
    public async Task<IActionResult> GetJewelryById(string id)
    {
        var jewelry = await JewelryService.GetJewelryById(id);
        if (jewelry == null) return NotFound();
        return Ok(jewelry);
    }
    [HttpPost("CreateJewelry")]
    public async Task<IActionResult> CreateJewelry(JewelryDto jewelryDto)
    {
        var jewelry = Mapper.Map<Jewelry>(jewelryDto);
        var result = await JewelryService.CreateJewelry(jewelry);
        return Ok(result);
    }
    [HttpPut("UpdateJewelry/{id}")]
    public async Task<IActionResult> UpdateJewelry(string id, JewelryDto jewelryDTO)
    {
        var jewelry = Mapper.Map<Jewelry>(jewelryDTO);
        var result = await JewelryService.UpdateJewelry(id, jewelry);
        return Ok(result);
    }
    [HttpDelete("DeleteJewelry/{id}")]
    public async Task<IActionResult> DeleteJewelry(string id)
    {
        var result = await JewelryService.DeleteJewelry(id);
        return Ok(result);
    }
}
