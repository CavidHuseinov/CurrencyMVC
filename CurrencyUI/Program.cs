using Currency.Business;
using Currency.Core.Settings;

namespace CurrencyUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.Configure<CurrencySettings>(builder.Configuration.GetSection("CurrencySettings"));
            builder.Services.AddHttpClient();
            builder.Services.AddMemoryCache();
            BusinessServiceRegistration.AddBusiness(builder.Services);


            var app = builder.Build();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Currency}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
