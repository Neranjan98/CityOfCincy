using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityOfCincy.Pages
{
    public class DepartmentsModel : PageModel
    {
        private readonly IDataResolver _dataResolver;

        public DepartmentsModel(IDataResolver dataResolver)
        {
            _dataResolver = dataResolver;
        }
        public async Task OnGet()
        {
            var departmentList = await _dataResolver.GetCincinnatiDepartmentInfo();
            ViewData["departmentData"] = departmentList;
        }
    }
}
