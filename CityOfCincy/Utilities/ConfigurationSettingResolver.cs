namespace CityOfCincy.Utilities
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
        public string GetAccessKey(string Key)
        {
            var searchString = "AccessKeys:" + Key;
            return _configuration[searchString];
        }
        public string GetConfiguration(string Configuration)
        {
            return _configuration[Configuration];
        }
    }
}
