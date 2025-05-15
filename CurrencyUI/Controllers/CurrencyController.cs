using Currency.Business.Services.Implementations;
using Currency.Business.Services.Interfaces;
using Currency.Business.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CurrencyUI.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ICurrencyService _services;
        private readonly ILogger<CurrencyController> _logger;
        public CurrencyController(ICurrencyService services, ILogger<CurrencyController> logger)
        {
            _services = services;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var json = await _services.GetCurrency();
                var dto = JsonConvert.DeserializeObject<CurrencyVM>(json);
                return View("~/Views/Currency/Index.cshtml", dto);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Currency datalarin cekmek mumkun olmadi xeta:{ex.Message}");
                return BadRequest(ex.Message);
            }
        }
    }
}
