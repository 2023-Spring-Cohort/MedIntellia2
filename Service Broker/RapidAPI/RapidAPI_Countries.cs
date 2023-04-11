using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Broker.RapidAPI
{
    public class RapidAPI_Countries : IRapidAPI_Countries
    {
        private readonly HttpClient httpClient;

        public RapidAPI_Countries(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<CountriesModel> GetCountriesAsync()
        {
            CountriesModel retValue = new CountriesModel();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/countries?offset=10"),
                Headers =
            {
                { "X-RapidAPI-Key", "94da19ee80msh0f726d42d24f17ep1275b4jsn5b5a7a541acb" },
                { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
            },
            };
            HttpResponseMessage? response = await httpClient.SendAsync(request);
            retValue = await response.ReadContentAsync<CountriesModel>();
            return retValue;
        }
    }
}
