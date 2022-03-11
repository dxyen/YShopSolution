using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YShopSolution.Application.System.Users;
using YShopSolution.ViewModels.Request.System.Users;

namespace YShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromForm]LoginRequest request)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var resultToken = await _userService.AuthencateAsync(request);
            if (resultToken == null)
            {
                return BadRequest("Username or passmord is incorrect");
            }
            return Ok(resultToken);
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm] RegisterRequest request)
        {   
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _userService.RegisterAsync(request);
            if (!result)
            {
                return BadRequest("Register is unsuccessful.");
            }
            return Ok();
        }
    }
}
