using App.Services;
using App.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace App.Support;

public static class Dependencies
{
    public static IServiceCollection AddApp(this IServiceCollection services)
    {
        RegisterServices(services);
        return services;
    }

    private static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IService, Service>();
    }
}