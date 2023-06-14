using AutoMapper;
using IdentityExample.Application.Abstractions.Context;
using IdentityExample.Application.Abstractions.Wrappers;
using IdentityExample.Application.DTOs;
using IdentityExample.Application.Wrappers;
using IdentityExample.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace IdentityExample.Application.Features.Queries.RoleQueries.GetAll
{
    public class GetAllRoleQueryHandler : IRequestHandler<GetAllRoleQueryRequest, IServiceResponse>
    {
        private readonly IApplicationDbContext _Context;
        private readonly IMapper _Mapper;

        public GetAllRoleQueryHandler(IApplicationDbContext Context, IMapper Mapper)
        {
            _Context = Context;
            _Mapper = Mapper;
        }

        public async Task<IServiceResponse> Handle(GetAllRoleQueryRequest request, CancellationToken cancellationToken)
        {
            Role[] DbRoles = await _Context.Roles.Where(r => !r.IsDeleted).ToArrayAsync();

            RoleDto[] Roles = _Mapper.Map<RoleDto[]>(DbRoles);    

            return new SuccessResponse<RoleDto[]>(Roles);
        }
    }
}
