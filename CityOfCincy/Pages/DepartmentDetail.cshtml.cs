using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityOfCincy.Pages
{
    public class DepartmentDetailModel : PageModel
    {
        private readonly IDataResolver _dataResolver;
        private readonly ConfigurationSettingResolver _configurationSettingResolver;

        public DepartmentDetailModel(IDataResolver dataResolver, ConfigurationSettingResolver configurationSettingResolver)
        {
            _dataResolver = dataResolver;
            _configurationSettingResolver = configurationSettingResolver;
        }
        public async Task OnGet(string inputDept, string stringName)
        {
            var department = await _dataResolver.GetIndividualCincinnatiDepartmentInfo(stringName);
            var salaryInfo = await _dataResolver.GetSalaryDataWithQueryParemeter("jobcode", inputDept);
            var mapsAccessKey = _configurationSettingResolver.GetAccessKey("MapsAPIKey");

            if(salaryInfo is not null && department is not null) 
            {
                ViewData["salaryInfo"] = salaryInfo;
                ViewData["departmentInfo"] = department.FirstOrDefault();
            }

            if(mapsAccessKey is not null)
            {
                ViewData["MapsKey"] = mapsAccessKey;
            }


        }
    }
}
