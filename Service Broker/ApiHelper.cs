using DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service_Broker
{
    public static class ApiHelper
    {
        public static async Task<T> ReadContentAsync<T>(this HttpResponseMessage response) 
        {
            if (response.IsSuccessStatusCode == false)
                throw new ApplicationException($"Something went wrong calling the API: " + response.ReasonPhrase);
            var dataAsString = await response.Content.ReadAsStringAsync();

            var settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
            //var objResult = JsonConvert.DeserializeObject<List<HospitalData>>(dataAsString);
            var result = JsonConvert.DeserializeObject<T>(dataAsString);

            return result;
        }
        public static async Task<List<HospitalData>> ReadHospitalDataContentAsync(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode == false)
                throw new ApplicationException($"Something went wrong calling the API: " + response.ReasonPhrase);
            var dataAsString = await response.Content.ReadAsStringAsync();

            var settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
            //var objResult = JsonConvert.DeserializeObject<List<HospitalData>>(dataAsString);
            var result = JsonConvert.DeserializeObject<List<HospitalData>>(dataAsString, settings);

            return result;
        }

        public static async Task<List<GeoCode_Data>> ReadGeoCodeDataContentAsync(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode == false)
                throw new ApplicationException($"Something went wrong calling the API: " + response.ReasonPhrase);
            var dataAsString = await response.Content.ReadAsStringAsync();

            var settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
            var result = JsonConvert.DeserializeObject<List<GeoCode_Data>>(dataAsString, settings);

            return result;
        }
    }
}
