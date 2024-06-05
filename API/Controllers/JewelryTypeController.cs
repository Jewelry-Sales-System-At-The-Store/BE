using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class JewelryTypeController(IJewelryTypeService service, IMapper mapper) : ControllerBase
{
    public IJewelryTypeService Service { get; } = service;
    public IMapper Mapper { get; } = mapper;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var jewelryTypes = await Service.GetJewelry();
        return Ok(jewelryTypes);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var jewelryType = await Service.GetJewelryById(id);
        return Ok(jewelryType);
    }
    [HttpPost]
    public async Task<IActionResult> CreateJewelryType(JewelryTypeDTO jewelryType)
    {
        var result = await Service.CreateJewelry(Mapper.Map<JewelryType>(jewelryType));
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateJewelryType(int id, JewelryTypeDTO jewelryType)
    {
        var result = await Service.UpdateJewelry(id, Mapper.Map<JewelryType>(jewelryType));
        return Ok(result);
    }
}