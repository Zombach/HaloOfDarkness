using Microsoft.Extensions.Configuration;

namespace Domain.Configurations;

public static class DomainConfigure
{
    public static void AddDomainService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMapperService();
    }
}