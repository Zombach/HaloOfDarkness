using Infrastructure.Contexts;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Configurations;

public static class InfrastructureConfigure
{
    public static void AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<PlayerContext>();
        services.AddSingleton<ItemsContext>();
    }
}