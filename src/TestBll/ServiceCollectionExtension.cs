using Microsoft.Extensions.DependencyInjection;
using TestDataAccessLayer;

namespace TestBusinessLogicLayer
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterBusinessLogic(this IServiceCollection services)
        {
            services.AddTransient<IBusinessLogic, BusinessLogic>();

            services.RegisterRepository();
        }
    }
}