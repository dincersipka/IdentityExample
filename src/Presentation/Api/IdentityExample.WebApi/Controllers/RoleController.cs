using IdentityExample.Application.Abstractions.Wrappers;
using IdentityExample.Application.Features.Queries.RoleQueries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityExample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public RoleController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            IServiceResponse Response = await _Mediator.Send(new GetAllRoleQueryRequest());

            return Ok(Response);
        }
    }
}
