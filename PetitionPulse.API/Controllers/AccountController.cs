using Microsoft.AspNetCore.Mvc;

using PetitionPulse.Core.Model.Account;
using PetitionPulse.Service.Services.Account;

namespace PetitionPulse.API.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserRequest request)
        {
            var response = await _accountService.Register(request);
            return Ok(response);
        }
    }
}
