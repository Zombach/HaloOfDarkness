using Core.Configurations;
using Domain.Configurations;
using Infrastructure.Configurations;
using Microsoft.Extensions.Configuration;

namespace HaloOfDarkness.Configurations;

public static class ServicesConfigure
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddInfrastructureService(configuration);
        services.AddDomainService(configuration);
        services.AddCoreServices(configuration);
    }
}