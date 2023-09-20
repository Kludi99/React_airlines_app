using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using React_airlines_common.Dto;

namespace React_airlines_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 0)
                return BadRequest();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserDto user)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UserDto user)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }

    }
}
