using BusinessObjects.Dto;
using BusinessObjects.Dto.Counter;
using BusinessObjects.Models;
using Management.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Interface;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserManagement userManagement, IUserService userService) : ControllerBase
{
    private IUserManagement UserManagement { get; } = userManagement;
    private IUserService UserService { get; } = userService;
    [EnableQuery]
    [HttpGet("GetUsers")]
    public async Task<IActionResult> Get()
    {
        var users = await UserManagement.GetUsers();
        return Ok(users);
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
    
    [HttpPost("Logout")]
    public async Task<IActionResult> Logout(string userId)
    {
        var logoutCounter = await UserManagement.Logout(userId);
        return Ok(logoutCounter);
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
    [HttpPut("UpdateCounterByUserId/{userId}/{counterId}")]
    public async Task<IActionResult> UpdateCounterByUserId(string userId, string counterId)
    {
        var result = await UserService.UpdateCounterByUserId(userId, counterId);
        if (result) return Ok(new { message = "Update counter success" });
        return BadRequest(new { message = "Update counter fail" });
    }
    [HttpDelete("DeleteUser/{id}")]
    public async Task<IActionResult> DeleteUser(string id)
    {
        var result = await UserManagement.DeleteUser(id);
        if (result > 0) return Ok(new { message = "Delete user success" });
        return BadRequest(new { message = "Delete user fail" });
    }
}
