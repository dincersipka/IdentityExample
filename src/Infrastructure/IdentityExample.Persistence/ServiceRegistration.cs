using IdentityExample.Application.Abstractions.Context;
using IdentityExample.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityExample.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection Services) 
        {
            Services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(opt => opt.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
