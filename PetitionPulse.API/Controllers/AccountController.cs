using Microsoft.AspNetCore.Mvc;

namespace PetitionPulse.API.Controllers
{
    public class AccountController : ControllerBase
    {

        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
