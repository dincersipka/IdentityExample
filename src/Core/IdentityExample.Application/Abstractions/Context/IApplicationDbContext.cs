using IdentityExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityExample.Application.Abstractions.Context
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Role> Roles { get; }

        Task<int> SaveChangesAsync(CancellationToken Token);
    }
}
