using AutoMapper;
using IdentityExample.Application.DTOs;
using IdentityExample.Domain.Entities;

namespace IdentityExample.Application.Mapping
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
        }
    }
}
