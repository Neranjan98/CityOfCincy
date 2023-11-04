using CityOfCincy.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CityOfCincy.Utilities
{
    public class APIDataResolver : IDataResolver
    {
        private readonly ConfigurationSettingResolver _configurationSettingResolver;

        public APIDataResolver(ConfigurationSettingResolver configurationSettingResolver)
        {
            _configurationSettingResolver = configurationSettingResolver;
        }

        public async Task<List<EmployeeSalaryResponse>?> GetCincinnatiSalaryInfo()
        {
            string CincinnatiSalaryURL = _configurationSettingResolver.GetCincinnatiSalaryURL();
            var SalaryRequest = new RestRequest(CincinnatiSalaryURL);
            var SalaryDataString = await APIRequestHandler.MakeGETRestRequest(SalaryRequest);

            if(!String.IsNullOrWhiteSpace(SalaryDataString)) 
            {
                return JsonConvert.DeserializeObject<List<EmployeeSalaryResponse>>(SalaryDataString);
            }
            else
            {
                return null;
            }

        }
        
        public async Task<List<EmployeeSalaryScheduleResponse>?> GetCincinnatiSalaryScheduleInfo()
        {
            string CincinnatiSalaryScheduleURL = _configurationSettingResolver.GetCincinnatiSalaryScheduleURL();
            var SalaryScheduleRequest = new RestRequest(CincinnatiSalaryScheduleURL);
            var SalaryScheduleString = await APIRequestHandler.MakeGETRestRequest(SalaryScheduleRequest);

            if(!String.IsNullOrWhiteSpace(SalaryScheduleString)) 
            {
                return JsonConvert.DeserializeObject<List<EmployeeSalaryScheduleResponse>>(SalaryScheduleString);
            }
            else
            {
                return null;
            }

        }

        public async Task<List<DepartmentInfoResponse>?> GetCincinnatiDepartmentInfo()
        {
            string CincinnatiDepartmentURL = _configurationSettingResolver.GetCincinnatiDepartmentURL();
            var DepartmentRequest = new RestRequest(CincinnatiDepartmentURL);
            var DepartmentInfoString = await APIRequestHandler.MakeGETRestRequest(DepartmentRequest);

            if(!String.IsNullOrWhiteSpace(DepartmentInfoString)) 
            {
                return JsonConvert.DeserializeObject<List<DepartmentInfoResponse>>(DepartmentInfoString);
            }
            else
            {
                return null;
            }

        }

        public async Task<List<EmployeeSalaryResponse>?> GetSalaryDataWithQueryParemeter(string queryParam, string value)
        {
            string CincinnatiSalaryURL = _configurationSettingResolver.GetCincinnatiSalaryURL();
            var SalaryRequest = new RestRequest(CincinnatiSalaryURL);
            SalaryRequest.AddQueryParameter(queryParam, value);
            var SalaryDataString = await APIRequestHandler.MakeGETRestRequest(SalaryRequest);

            if (!String.IsNullOrWhiteSpace(SalaryDataString))
            {
                return JsonConvert.DeserializeObject<List<EmployeeSalaryResponse>>(SalaryDataString);
            }
            else
            {
                return null;
            }

        }

        public async Task<List<DepartmentInfoResponse>>? GetIndividualCincinnatiDepartmentInfo(string dept_code)
        {
            string CincinnatiDepartmentURL = _configurationSettingResolver.GetCincinnatiDepartmentURL();
            var DeptRequest = new RestRequest(CincinnatiDepartmentURL);
            DeptRequest.AddQueryParameter("department", dept_code);
            var SalaryDataString = await APIRequestHandler.MakeGETRestRequest(DeptRequest);

            if (!String.IsNullOrWhiteSpace(SalaryDataString))
            {
                return JsonConvert.DeserializeObject<List<DepartmentInfoResponse>>(SalaryDataString);
            }
            else
            {
                return null;
            }

        }

    }
}
