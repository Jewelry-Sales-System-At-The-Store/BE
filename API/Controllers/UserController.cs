using BusinessObjects.Dto;
using Management.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserManagement userManagement) : ControllerBase
{
    private IUserManagement UserManagement { get; } = userManagement;
    [EnableQuery]
    [HttpGet("GetUsers")]
    public async Task<IActionResult> Get()
    {
        var users = await UserManagement.GetUsers();
        return Ok(users.AsQueryable());
    }
    [HttpGet("GetUserById/{id}")]
    public async Task<IActionResult> GetUserById(string id)
    {
        var user = await UserManagement.GetUserById(id);
        if (user != null) return Ok(user);
        return NotFound(new { message = "User not found" });
    }
    [AllowAnonymous]
    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var token = await UserManagement.Login(loginDto);
        if (token != null) return Ok(token);
        return NotFound(new { message = "Login fail" });
    }
    [HttpPost("AddUser")]
    public async Task<IActionResult> AddUser(UserDto userDto)
    {
        var result = await UserManagement.AddUser(userDto);
        if (result > 0) return Ok(new { message = "Add user success" });
        return BadRequest(new { message = "Add user fail" });
    }
    [HttpPut("UpdateUser/{id}")]
    public async Task<IActionResult> UpdateUser(string id, UserDto userDto)
    {
        var result = await UserManagement.UpdateUser(id, userDto);
        if (result > 0) return Ok(new { message = "Update user success" });
        return BadRequest(new { message = "Update user fail" });
    }
    [HttpDelete("DeleteUser/{id}")]
    public async Task<IActionResult> DeleteUser(string id)
    {
        var result = await UserManagement.DeleteUser(id);
        if (result > 0) return Ok(new { message = "Delete user success" });
        return BadRequest(new { message = "Delete user fail" });
    }
}
