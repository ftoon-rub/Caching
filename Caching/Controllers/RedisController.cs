using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsersAsRedisString()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddUserAsRedisString()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult EditUserAsRedisString(int id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteUserAsRedisString(int id)
        {
            return Ok();
        }
    }
}
