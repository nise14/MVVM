namespace Cats.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services, CatsEndpoints endpoints)
    {
        services.AddHttpClient<ICatsModel, CatsModel>(httpclient =>
            new CatsModel(httpclient, endpoints));

        services.AddScoped<ICatsViewModel, CatsViewModel>();

        return services;
    }

    public static IServiceCollection AddConsoleServices(this IServiceCollection services, CatsEndpoints endpoints)
    {
        services.AddCoreServices(endpoints);
        services.AddScoped<ICatsView, CatsView>();

        return services;
    }
}