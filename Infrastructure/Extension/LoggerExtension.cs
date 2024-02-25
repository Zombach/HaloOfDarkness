using Microsoft.Extensions.Configuration;
using Serilog;

namespace Infrastructure.Extension;

public static class LoggerExtension
{
    public static void AddLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log.txt"), rollingInterval: RollingInterval.Day)
            .WriteTo.Debug()
            .CreateLogger();
    }
}