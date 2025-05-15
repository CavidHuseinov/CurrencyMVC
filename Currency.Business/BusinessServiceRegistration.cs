
using Currency.Business.Services.Implementations;
using Currency.Business.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Currency.Business
{
    public static class BusinessServiceRegistration
    {
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<ICurrencyService, CurrencyService>();
        }
    }
}
