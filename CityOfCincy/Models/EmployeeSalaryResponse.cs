using System.ComponentModel.DataAnnotations;

namespace CityOfCincy.Models
{
    public class EmployeeSalaryResponse
    {
        public string? age_range { get; set; }
        public string? name { get; set; }
        public string? sex { get; set; }
        public string? race { get; set; }
        public string? business_title { get; set; }
        public string? deptid { get; set; }
        public string? jobcode { get; set; }
        public string? position_nbr { get; set; }
        public string? location { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? job_entry_dt { get; set; }
        public string? paygroup { get; set; }
        public string? std_hours { get; set; }
        public string? fte { get; set; }
        public string? sal_admin_plan { get; set; }
        public string? grade { get; set; }
        public string? step { get; set; }
        
        [DataType(DataType.Currency)]
        public string? annual_rt { get; set; }
        public string? eeo_job_group { get; set; }
        public string? job_family { get; set; }
        public string? jobtitle { get; set; }
        public string? jobtitle_abbrv { get; set; }
        public string? deptname { get; set; }
        public string? deptname_abbrv { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? hire_date { get; set; }
    }
}
