using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityOfCincy.Pages
{
    public class SalaryInformationModel : PageModel
    {
        private readonly IDataResolver _dataResolver;

        public SalaryInformationModel(IDataResolver dataResolver)
        {
            _dataResolver = dataResolver;   
        }
        public async Task OnGet()
        {
            var salaryData = await _dataResolver.GetCincinnatiSalaryInfo();

            ViewData["salaryResult"] = salaryData;

        }
    }
}
