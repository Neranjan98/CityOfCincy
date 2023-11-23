using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityOfCincy.Pages
{
    public class ChicagoDataModel : PageModel
    {
        private readonly IDataResolver _dataResolver;

        public ChicagoDataModel(IDataResolver dataResolver)
        {
            _dataResolver = dataResolver;
        }
        public async Task OnGet()
        {
            var ChicagoData = await _dataResolver.GetChicagoData();
            var SaleStatusOptions = ChicagoData
                .GroupBy(x => x.sales_status)
                .Select(x => x.Key)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToList();

            
            ViewData["ChicagoDataOptions"] = SaleStatusOptions;


        }
    }
}
