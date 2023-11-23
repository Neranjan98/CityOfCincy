using CityOfCincy.Models;

namespace CityOfCincy.Utilities
{
    public interface IDataResolver
    {
        Task<List<EmployeeSalaryResponse>?> GetCincinnatiSalaryInfo();
        Task<List<EmployeeSalaryResponse>?> GetSalaryDataWithQueryParemeter(string queryParam, string value);
        Task<List<EmployeeSalaryScheduleResponse>?> GetCincinnatiSalaryScheduleInfo();
        Task<List<DepartmentInfoResponse>?> GetCincinnatiDepartmentInfo();
        Task<List<DepartmentInfoResponse>?> GetIndividualCincinnatiDepartmentInfo(string dept_code);
        Task<List<ChicagoHousingResponse>?> GetChicagoData();
        Task<List<ChicagoHousingResponse>?> GetChicagoDataBySalesStatus(string SalesStatus);
    }
}