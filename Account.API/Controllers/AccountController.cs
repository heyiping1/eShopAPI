using ApplicationCore;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.Requests;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync _accountService;
        public AccountController(IAccountServiceAsync accountService)
        {
            _accountService = accountService;
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            var result = await _accountService.SignUpAsync(model);
            if (result.Succeeded)
            {
                return Ok("Account has been created successfully");

            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var result = await _accountService.LoginAsync(model);
            return Ok(result);
        }
    }
}