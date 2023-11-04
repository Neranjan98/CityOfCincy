﻿namespace CityOfCincy.Utilities
{
    public class ConfigurationSettingResolver
    {
        private readonly IConfiguration _configuration;

        public ConfigurationSettingResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetCincinnatiSalaryScheduleURL()
        {
            return _configuration["CincinnatiDataURLs:CincinnatiSalaryScheduleURL"];
        }
        public string GetCincinnatiSalaryURL()
        {
            return _configuration["CincinnatiDataURLs:CincinnatiSalaryURL"];
        }
        public string GetCincinnatiDepartmentURL()
        {
            return _configuration["CincinnatiDataURLs:CincinnatiDepartmentURL"];
        }
    }
}
