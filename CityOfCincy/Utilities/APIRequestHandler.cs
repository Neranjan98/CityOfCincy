using RestSharp;

namespace CityOfCincy.Utilities
{
    public static class APIRequestHandler
    {
        public static async Task<string> MakeGETRestRequest(RestRequest restRequest)
        {
            RestClient restClient = new();
            RestResponse restResponse = new();
            restResponse = await restClient.GetAsync(restRequest);
            string returnString;
            if (restResponse.IsSuccessful)
            {
                if (!String.IsNullOrWhiteSpace(restResponse.Content))
                {
                    returnString = restResponse.Content;
                }
                else
                {
                    returnString = String.Empty;
                }
            }
            else
            {
                returnString = String.Empty;
            }
            restClient.Dispose();

            return returnString;
        }

    }
}
