using DataModel;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Broker.Public
{
    public class CMI_Service : ICMI_Service
    {
        private readonly HttpClient httpClient;

        public CMI_Service(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        //public async Task<CMI_Model> GetCMIAsync()
        //{
        //    CMI_Model retValue = new CMI_Model();
        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Get,
        //        RequestUri = new Uri("https://www.communitybenefitinsight.org/api/get_hospital_data.php?hospital_id=1000"),
        //    };
        //    HttpResponseMessage? response = await httpClient.SendAsync(request);
        //    retValue = await response.ReadContentAsync<CMI_Model>();
        //    return retValue;
        //}

        public async Task<List<HospitalData>> GetCMIAsync(int id=1000)
        {
            List<HospitalData> retValue = new List<HospitalData>();
            HttpResponseMessage? response = await httpClient.GetAsync($"?hospital_id={id}");
            retValue = await response.ReadHospitalDataContentAsync();
            return retValue;
        }
        public async Task<List<HospitalData>> GetCMI_Details_Async(string state)
        {
            List<HospitalData> retValue = new List<HospitalData>();
            HttpResponseMessage? response = await httpClient.GetAsync($"?{state}");
            retValue = await response.ReadHospitalDataContentAsync();
            return retValue;
        }
    }
}
