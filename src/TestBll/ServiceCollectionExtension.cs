using TestBusinessLogicLayer;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection 
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            services
                .AddRepository()
                .AddTransient<IBusinessLogic, BusinessLogic>();

            return services;
        }
    }
}