using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityOfCincy.Pages
{
    public class DepartmentDetailModel : PageModel
    {
        private readonly IDataResolver _dataResolver;

        public DepartmentDetailModel(IDataResolver dataResolver)
        {
            _dataResolver = dataResolver;
        }
        public async Task<RedirectToPageResult> OnGet(string inputDept, string stringName)
        {
            var department = await _dataResolver.GetIndividualCincinnatiDepartmentInfo(stringName);
            var salaryInfo = await _dataResolver.GetSalaryDataWithQueryParemeter("jobcode", inputDept);

            if (salaryInfo is not null && department is not null)
            {
                ViewData["salaryInfo"] = salaryInfo;
                ViewData["departmentInfo"] = department.FirstOrDefault();
            }
            else _ = salaryInfo is null || department is null;
            {
                return RedirectToPage("./Index");
            }




        }
    }
}
