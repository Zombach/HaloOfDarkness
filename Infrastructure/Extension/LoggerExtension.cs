using Serilog;

namespace Infrastructure.Extension;

public static class LoggerExtension
{
    public static void AddLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }
}