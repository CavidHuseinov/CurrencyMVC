
using Currency.Business.Services.Interfaces;
using Microsoft.Extensions.Hosting;

namespace Currency.Infrastructure.BackgroundServices
{
    public class CurrencyBG : BackgroundService
    {
        private readonly ICurrencyService _currencyService;

        public CurrencyBG(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _currencyService.GetCurrency();

                await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
            }
        }
    }
}
