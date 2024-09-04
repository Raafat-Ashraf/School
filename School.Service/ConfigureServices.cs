using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using School.Service.Abstracts;
using School.Service.Implementations;
using System.Reflection;

namespace School.Service;
public static class ConfigureServices
{
    public static IServiceCollection AddServiceServices(this IServiceCollection services)
    {
        services
            .AddMapsterServices();


        services.AddScoped<IStudentService, StudentService>();

        return services;
    }

    private static IServiceCollection AddMapsterServices(this IServiceCollection services)
    {
        var mappingConfig = TypeAdapterConfig.GlobalSettings;
        mappingConfig.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton<IMapper>(new Mapper(mappingConfig));


        return services;
    }
}
