using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Csore_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AutController : ControllerBase
    {
        private readonly AuthService _authService;

        public AutController(AuthService authService)
        {
            _authService = authService; 
        }

        [HttpPost]
        [ActionName("register")]
        public async Task<IActionResult> CreateUser(RegisterUser user)
        {
            if (ModelState.IsValid)
            {
                var response = await _authService.RegisterNewUserAsync(user);
                
                return Ok(response);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        [ActionName("login")]
        public async Task<IActionResult> Login(LoginUser inputModel)
        {
            if (ModelState.IsValid)
            {
                var token = await _authService.AuthenticateUserAsync(inputModel);
                if (token == null)
                {
                    return Unauthorized("The Authentication Failed");
                }
                // send token to client
                var ResponseData = new ResponseData()
                {
                    Message = token
                };

                return Ok(ResponseData);
            }
            return BadRequest(ModelState);
        }
    }
}
