using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace School.Core;
public static class ConfigureServices
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services
            .AddMediatRConfig();


        return services;
    }

    private static IServiceCollection AddMediatRConfig(this IServiceCollection services)
    {
        services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }


}
