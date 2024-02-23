using HaloOfDarkness.Configurations;
using Microsoft.Extensions.Logging;
using UserInterface;

namespace HaloOfDarkness;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        try
        {
            var builder = MauiApp.CreateBuilder();
            builder.Configuration.AddJsonConfigure("appsettings.json");

#if DEBUG
            builder.Configuration.AddJsonConfigure("appsettings.development.json");
#else
            builder.Configuration.AddJsonConfigure("appsettings.production.json");
#endif

            builder.UseMauiApp<App>()
            .ConfigureFonts
            (
                fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }
            );

            builder.Services.AddHaloOfDarknessService();
            builder.Services.AddServices(builder.Configuration);

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}