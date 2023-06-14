using IdentityExample.Application.Abstractions.Context;
using IdentityExample.Application.Abstractions.Token;
using IdentityExample.Application.Abstractions.Wrappers;
using IdentityExample.Application.Exceptions;
using IdentityExample.Application.Wrappers;
using IdentityExample.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace IdentityExample.Application.Features.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, IServiceResponse>
    {
        private readonly IApplicationDbContext _Context;
        private readonly ITokenHandler _TokenHandler;

        public LoginUserCommandHandler(IApplicationDbContext Context, ITokenHandler TokenHandler)
        {
            _Context = Context;
            _TokenHandler = TokenHandler;
        }

        public async Task<IServiceResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            User? DbUser = await _Context.Users.Where(u => u.Username == request.Username && u.Password == request.Password).FirstOrDefaultAsync();

            if (DbUser is null)
                throw new UserNotFoundException("User not found! Username or password may be incorrect!");

            LoginUserCommandResponse Response = new() { Token = _TokenHandler.CreateToken() };

            return new SuccessResponse<LoginUserCommandResponse>(Response); 
        }
    }
}
