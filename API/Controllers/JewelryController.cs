
using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.DTO.Jewelry;
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
    public async Task<IActionResult> CreateJewelry(JewelryRequestDto jewelryRequestDto)
    {
        var result = await JewelryService.CreateJewelry(jewelryRequestDto);
        return Ok(result);
    }
    [HttpPut("UpdateJewelry/{id}")]
    public async Task<IActionResult> UpdateJewelry(string id, JewelryRequestDto jewelryRequestDto)
    {
        var jewelry = Mapper.Map<Jewelry>(jewelryRequestDto);
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
