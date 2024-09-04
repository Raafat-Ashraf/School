namespace School.Api;

public static class ConfigureServices
{
    public static IServiceCollection AddInApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();

        services
            .AddInSwaggerConfig();


        return services;
    }


    private static IServiceCollection AddInSwaggerConfig(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }


}
