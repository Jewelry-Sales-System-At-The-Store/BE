using BusinessObjects.Dto;
using Management.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserManagement userManagement) : ControllerBase
{
    private IUserManagement UserManagement { get; } = userManagement;
    [HttpGet("GetUsers")]
    public async Task<IActionResult> Get()
    {
        var users = await UserManagement.GetUsers();
        return Ok(users);
    }
    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var user = await UserManagement.Login(loginDto);
        if (user != null) return Ok(user);
        return NotFound(new { message = "Login fail" });
    }
}
