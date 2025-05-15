
using Currency.Infrastructure.BackgroundServices;
using Microsoft.Extensions.DependencyInjection;

namespace Currency.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddHostedService<CurrencyBG>();
        }
    }
}
