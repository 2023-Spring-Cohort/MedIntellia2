using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Broker.Public
{
    public class GeoCoderService : IGeoCoderService
    {
        private readonly HttpClient httpClient;

        public GeoCoderService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<GeoCode_Data>> GetGeoCodeAsync(string loc = "Dayton%20OH")
        {
            List<GeoCode_Data> retValue = new List<GeoCode_Data>();
            HttpResponseMessage? response = await httpClient.GetAsync($"?q={loc}");
            retValue = await response.ReadGeoCodeDataContentAsync();
            return retValue;
        }
        public async Task<List<HospitalData>> GetCMIAsync(int id = 1000)
        {
            List<HospitalData> retValue = new List<HospitalData>();
            HttpResponseMessage? response = await httpClient.GetAsync($"?hospital_id={id}");
            retValue = await response.ReadHospitalDataContentAsync();
            return retValue;
        }
    }
}
