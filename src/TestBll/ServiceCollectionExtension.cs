using TestBusinessLogicLayer;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection 
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            services
                .AddTransient<IBusinessLogic, BusinessLogic>()
                .AddRepository();

            return services;
        }
    }
}