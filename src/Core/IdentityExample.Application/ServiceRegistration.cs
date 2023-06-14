using Microsoft.Extensions.DependencyInjection;

namespace IdentityExample.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection Services) 
        {
            Services.AddMediatR(opt => opt.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
        }
    }
}
