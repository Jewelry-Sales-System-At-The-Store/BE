
using BusinessObjects.DTO;
using Management.Interface;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserManagement userManagement) : ControllerBase
{
    public IUserManagement UserManagement { get; } = userManagement;
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await UserManagement.GetUsers();
        return Ok(users);
    }
    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginDto loginDTO)
    {
        var user = await UserManagement.Login(loginDTO);
        return Ok(user!=null);
    }
}
