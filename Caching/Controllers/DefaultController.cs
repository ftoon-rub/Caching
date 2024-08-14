using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caching.Controllers
{
    [Route("/")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("api is up and running");
        }
    }
}
