using TestDataAccessLayer;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection 
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IRepository, Repository>();

            return services;
        }
    }
}