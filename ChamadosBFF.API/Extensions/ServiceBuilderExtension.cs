namespace ChamadosBFF.API.Extensions
{
    public static class ServiceBuilderExtension
    {
        public static IServiceCollection AddMyDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IServiceCollection AddMyRepositories(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddMyServicesForMVP24(this IServiceCollection services)
        {
            return services;
        }

    }
}
