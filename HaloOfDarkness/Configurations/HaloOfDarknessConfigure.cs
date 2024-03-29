﻿using System.Reflection;
using Core.Common.Behaviors;
using Core.Configurations;
using Domain.Configurations;
using Infrastructure.Configurations;
using MediatR;

namespace HaloOfDarkness.Configurations;

public static class HaloOfDarknessConfigure
{
    public static void AddHaloOfDarknessService(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies
            (
                assembly,
                typeof(DomainConfigure).Assembly,
                typeof(InfrastructureConfigure).Assembly,
                typeof(CoreConfigure).Assembly
            );

            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        });
    }
}