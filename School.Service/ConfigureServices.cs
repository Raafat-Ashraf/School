using Microsoft.Extensions.DependencyInjection;
using School.Service.Abstracts;
using School.Service.Implementations;

namespace School.Service;
public static class ConfigureServices
{
    public static IServiceCollection AddServiceServices(this IServiceCollection services)
    {
        services.AddScoped<IStudentService, StudentService>();

        return services;
    }

}
