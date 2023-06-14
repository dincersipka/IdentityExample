using IdentityExample.Application.Abstractions.Wrappers;
using MediatR;

namespace IdentityExample.Application.Features.Commands.LoginUser
{
    public class LoginUserCommandRequest : IRequest<IServiceResponse>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
