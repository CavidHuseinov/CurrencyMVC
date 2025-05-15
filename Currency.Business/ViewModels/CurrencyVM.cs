
namespace Currency.Business.ViewModels
{
    public class CurrencyVM
    {
        public DateTime Date { get; set; }
        public string Base { get; set; } = "";
        public Dictionary<string, string> Rates { get; set; } = new();
    }
}
