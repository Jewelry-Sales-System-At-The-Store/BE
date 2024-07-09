using BusinessObjects.Dto;
using Management.Interface;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoleController(IRoleService roleService) : ControllerBase
{
    public IRoleService RoleService { get; } = roleService;

    [HttpGet("GetRoles")]
    public async Task<IActionResult> GetRoles()
    {
        return Ok(await roleService.Gets());
    }
    [HttpGet("GetRoleById/{roleId}")]
    public async Task<IActionResult> GetRoleById(string roleId)
    {
        return Ok(await roleService.GetById(roleId));
    }
    [HttpPost("CreateRole")]
    public async Task<IActionResult> CreateRole(RoleDto roleDto)
    {
        return Ok(await roleService.Create(roleDto));
    }
}
