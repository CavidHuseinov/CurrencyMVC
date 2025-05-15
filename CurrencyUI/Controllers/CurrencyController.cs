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

        public CurrencyController(ICurrencyService services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            var json = await _services.GetCurrency();
            var dto = JsonConvert.DeserializeObject<CurrencyVM>(json);
            return View("~/Views/Currency/Index.cshtml", dto);

        }
    }
}
