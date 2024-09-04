using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using School.Infrastructure.Persistence;
using School.Infrastructure.Persistence.Abstracts;
using School.Infrastructure.Persistence.Repositories;

namespace School.Infrastructure;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddDbConfig(configuration)
            .AddDependencies();

        return services;
    }


    private static IServiceCollection AddDbConfig(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationDbContext>(x =>
        {
            x.UseSqlServer(connectionString);
        });

        return services;
    }

    private static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IStudentRepository, StudentRepository>();


        return services;
    }



}
