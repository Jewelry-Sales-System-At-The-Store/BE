using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CounterController(ICounterService counterService) : ControllerBase
{
    private ICounterService CounterService { get; } = counterService;

    [HttpGet("GetCounterById/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var counter = await CounterService.GetCounterById(id);
        if (counter == null) return NotFound();
        return Ok(counter);
    }
}