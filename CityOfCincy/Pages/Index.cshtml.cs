using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityOfCincy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDataResolver _dataResolver;

        public IndexModel(ILogger<IndexModel> logger,
            IDataResolver dataResolver)
        {
            _logger = logger;
            _dataResolver = dataResolver;
        }

        public async Task OnGet()
        {
            var salaryData = await _dataResolver.GetCincinnatiSalaryInfo();
            var departmentData = await _dataResolver.GetCincinnatiDepartmentInfo();
            var salaryScheduleData = await _dataResolver.GetCincinnatiSalaryScheduleInfo();
        }
    }
}