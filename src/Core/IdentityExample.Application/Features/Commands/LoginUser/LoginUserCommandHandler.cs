using IdentityExample.Application.Abstractions.Context;
using IdentityExample.Application.Exceptions;
using IdentityExample.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace IdentityExample.Application.Features.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        private readonly IApplicationDbContext _Context;

        public LoginUserCommandHandler(IApplicationDbContext Context)
        {
            _Context = Context;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            User? DbUser = await _Context.Users.Where(u => u.Username == request.Username && u.Password == request.Password).FirstOrDefaultAsync();

            if (DbUser is null)
                throw new UserNotFoundException("User not found! Username or password may be incorrect!");

            return null;
        }
    }
}
