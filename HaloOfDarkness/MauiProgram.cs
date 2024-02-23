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
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

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