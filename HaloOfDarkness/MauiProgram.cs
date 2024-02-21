using HaloOfDarkness.Database;
using HaloOfDarkness.Database.Contexts;
using Microsoft.Extensions.Logging;

namespace MobileRpg;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<PlayerContext>();
        builder.Services.AddSingleton<ObjectsContext>();
        builder.Services.AddSingleton<TextsContext>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}