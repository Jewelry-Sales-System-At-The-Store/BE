
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        public IUserService UserService { get; } = userService;
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await UserService.GetUsers();
            return Ok(users);
        }
    }
}
