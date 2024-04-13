using HaloOfDarkness.Configurations;
using HaloOfDarkness.Configurations.Logger;
using Microsoft.Extensions.Logging;
using UserInterface;
using UserInterface.Pages;

namespace HaloOfDarkness;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        ILogger? logger = default;
        try
        {
            var builder = MauiApp.CreateBuilder();

            builder.Configuration.AddJsonConfigure("appsettings.json");
#if DEBUG
            builder.Configuration.AddJsonConfigure("appsettings.development.json");
#else
            builder.Configuration.AddJsonConfigure("appsettings.production.json");
#endif

            logger = LoggerFactory.Create
            (
                configure => configure.Services
                    .AddLogging
                    (
                        loggerBuilder => loggerBuilder
                            .AddDebug()
                            .AddJsonConsole()
                            .AddFile("log.txt")
                    )
            ).CreateLogger(typeof(App));

            logger.LogInformation("info");

            builder.UseMauiApp<App>()
                .ConfigureFonts
                (
                    fonts =>
                    {
                        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                        fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    }
                );

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<SettingsPage>();

            builder.Services.AddServices(builder.Configuration);

            return builder.Build();
        }
        catch (Exception e)
        {
            Serilog.Log.Error(e, e.Message);
            throw;
        }
    }
}