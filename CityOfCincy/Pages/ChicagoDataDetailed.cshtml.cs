using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityOfCincy.Pages
{
    public class ChicagoDataDetailedModel : PageModel
    {
        private readonly IDataResolver _dataResolver;

        public ChicagoDataDetailedModel(IDataResolver dataResolver)
        {
            _dataResolver = dataResolver;
        }
        public async Task OnGet(string status)
        {
            var searchData = await _dataResolver.GetChicagoDataBySalesStatus(status);

            if (searchData != null)
            {
                ViewData["ChicagoSearchData"] = searchData;
            }
            else
            {
                ViewData["ErrorMessage"] = "Sorry! Some error occured.";
            }

            ViewData["Status"] = status;
        }
    }
}
