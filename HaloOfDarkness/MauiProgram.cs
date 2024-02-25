using HaloOfDarkness.Configurations;
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