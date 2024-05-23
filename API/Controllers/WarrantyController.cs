using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WarrantyController(IWarrantyService warrantyService, IMapper mapper) : ControllerBase
{
    private readonly IMapper mapper = mapper;

    public IWarrantyService WarrantyService { get; } = warrantyService;
    public IMapper Mapper => mapper;
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var warranties = await WarrantyService.GetWarranties();
        return Ok(warranties);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var warranty = await WarrantyService.GetWarrantyById(id);
        return Ok(warranty);
    }
    [HttpPost]
    public async Task<IActionResult> CreateWarranty(WarrantyDTO warrantyDTO)
    {
        var warrantyEntity = mapper.Map<Warranty>(warrantyDTO);
        var result = await WarrantyService.CreateWarranty(warrantyEntity);
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateWarranty([FromQuery]int id,WarrantyDTO warrantyDTO)
    {
        var warrantyEntity = mapper.Map<Warranty>(warrantyDTO);
        var result = await WarrantyService.UpdateWarranty(id ,warrantyEntity);
        return Ok(result);
    }
}
