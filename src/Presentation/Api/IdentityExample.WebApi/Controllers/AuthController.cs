using IdentityExample.Application.Features.Commands.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityExample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public AuthController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommandRequest Request)
        {
            LoginUserCommandResponse Response = await _Mediator.Send(Request);

            return Ok(Response);
        }
    }
}
