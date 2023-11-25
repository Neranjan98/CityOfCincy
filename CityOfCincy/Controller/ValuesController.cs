using CityOfCincy.Utilities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityOfCincy.Controller
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IDataResolver _dataResolver;
        private readonly ILogger<DataController> _logger;
        
        public DataController(ILogger<DataController> logger,
            IDataResolver dataResolver)
        {
            _dataResolver = dataResolver;
            _logger = logger; 
        }

        [HttpGet("GetData", Name = "GetData")]
        public async Task<IActionResult> Get()
        {
            var department = await _dataResolver.GetCincinnatiDepartmentInfo();
            var salaryInfo = await _dataResolver.GetCincinnatiSalaryInfo();

            if (department is not null && salaryInfo is not null)
            {
                var joinedData = department.Join(salaryInfo,
                                     dept => dept.department_codes,
                                     salary => salary.jobcode,
                                     (dept, salary) => new
                                     {
                                         JobCode = salary.jobcode,
                                         Department_Name = dept.department,
                                         SalaryInfo = salary.annual_rt
                                     })
                               .ToList();

                return Ok(joinedData);
            }

            return BadRequest("Sorry Some Error Occured");
            
        }

        [HttpGet("GetDataByDeptName", Name = "GetDataByDeptName")]
        public async Task<IActionResult> GetByDeptName(string DeptName)
        {

            if (String.IsNullOrWhiteSpace(DeptName))
            {   
                return BadRequest("Department Name is null");
            }

            var department = await _dataResolver.GetCincinnatiDepartmentInfo();
            var salaryInfo = await _dataResolver.GetCincinnatiSalaryInfo();

            if(department is not null 
                && salaryInfo is not null)


            {
                var joinedData = department.Join(salaryInfo,
                                     dept => dept.department_codes,
                                     salary => salary.jobcode,
                                     (dept, salary) => new
                                     {
                                         JobCode = salary.jobcode,
                                         Department_Name = dept.department,
                                         SalaryInfo = salary.annual_rt
                                     })
                               .ToList()
                               .Where(x => x.Department_Name.Contains(DeptName))
                               .FirstOrDefault();

                return Ok(joinedData);
            }

            return BadRequest("Sorry Some Error Occured");


        }
        
    }

}
