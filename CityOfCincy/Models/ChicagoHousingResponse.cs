namespace CityOfCincy.Models
{

    public class ChicagoHousingResponse
    {
        public string? id { get; set; }
        public string? pin { get; set; }
        public string? address { get; set; }
        public string? managing_organization { get; set; }
        public string? property_status { get; set; }
        public string? sales_status { get; set; }
        public string? sale_offering_status { get; set; }
        public string? sale_offering_reason { get; set; }
        public string? sq_ft { get; set; }
        public string? square_footage_city_estimate { get; set; }
        public string? land_value { get; set; }
        public string? ward { get; set; }
        public string? community_area_number { get; set; }
        public string? community_area_name { get; set; }
        public string? zoning_classification { get; set; }
        public string? zip_code { get; set; }
        public string? last_update { get; set; }
        public string? x_coordinate { get; set; }
        public string? y_coordinate { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public Location? location { get; set; }
    }

    public class Location
    {
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public string? human_address { get; set; }
    }

}
