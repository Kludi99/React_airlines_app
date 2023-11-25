using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using React_airlines_Core.Interfaces.Models.Dto;
using React_airlines_Core.Interfaces.Services;

namespace React_airlines_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly IUserService userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            this.logger = logger;
            this.userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 0)
                return BadRequest();

            var result = await userService.GetUserById(id);
            return Ok(result);
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
