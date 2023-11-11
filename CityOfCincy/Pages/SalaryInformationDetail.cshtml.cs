using CityOfCincy.Models;
using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityOfCincy.Pages
{
    public class SalaryInformationDetailModel : PageModel
    {
        private readonly IDataResolver _dataResolver;

        public SalaryInformationDetailModel(IDataResolver dataResolver)
        {
            _dataResolver = dataResolver;
        }
        public async Task OnGet(string inputDept)
        {
            var salaryData = await _dataResolver.GetSalaryDataWithQueryParemeter("deptid", inputDept);

            ViewData["individualSalaryResult"] = salaryData;

        }

    }

}


