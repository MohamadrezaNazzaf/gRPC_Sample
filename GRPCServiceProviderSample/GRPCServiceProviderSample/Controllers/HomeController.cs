using Microsoft.AspNetCore.Mvc;

namespace GRPCServiceProviderSample.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
