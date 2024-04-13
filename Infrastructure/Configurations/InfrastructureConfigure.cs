using Infrastructure.Contexts;
using Infrastructure.Extension;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Configurations;

public static class InfrastructureConfigure
{
    public static void AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
    {
        LoggerExtension.AddLogger();
        services.AddSingleton<PlayerContext>();
        services.AddSingleton<ItemsContext>();
        Serilog.Log.Logger.Warning("test console");
    }
}