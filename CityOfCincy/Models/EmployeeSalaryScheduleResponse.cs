using System.ComponentModel.DataAnnotations;

namespace CityOfCincy.Models
{
    public class EmployeeSalaryScheduleResponse
    {

        public string? description { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? effective_date { get; set; }
        public string? salary_plan { get; set; }
        public string? salary_plan_desc { get; set; }
        public string? grade { get; set; }
        public string? min_hour { get; set; }
        public string? max_hour { get; set; }
        [DataType(DataType.Currency)]
        public string? min_annual { get; set; }
        [DataType(DataType.Currency)]
        public string? max_annual { get; set; }

    }
}
