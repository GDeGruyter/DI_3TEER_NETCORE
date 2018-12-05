using Microsoft.Extensions.DependencyInjection;

namespace TestDataAccessLayer
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterRepository(this IServiceCollection services)
        {
            services.AddTransient<IRepository, Repository>();
        }
    }
}