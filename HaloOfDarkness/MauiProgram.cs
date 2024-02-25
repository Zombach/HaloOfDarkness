﻿using HaloOfDarkness.Configurations;
using HaloOfDarkness.Configurations.Logger;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
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


            var logger = LoggerFactory.Create(x => x.Services.AddLogging(l => l.AddDebug().AddJsonConsole().AddFile("log.txt")))
                .CreateLogger(typeof(App));

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

            builder.Services.AddServices(builder.Configuration);

            return builder.Build();
        }
        catch (Exception e)
        {
            //Logger<>.Error("{@message}", e.Message);
            throw;
        }
    }
}