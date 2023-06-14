using IdentityExample.Application.Abstractions.Token;
using IdentityExample.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityExample.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection Services)
        {
            Services.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
