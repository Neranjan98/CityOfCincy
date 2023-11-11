using System.ComponentModel.DataAnnotations;

namespace CityOfCincy.Models
{
    public class DepartmentInfoResponse
    {
        [MaxLength(50)]
        public string? department_codes { get; set; }
        [MaxLength(100)]
        public string? department { get; set; }
        [MaxLength(50)]
        public string? director { get; set; }
        [MaxLength(200)]
        public string? department_main_website { get; set; }
        [MaxLength(150)]
        public string? department_contact_information { get; set; }
    }
}

