using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Broker.Public
{
    public class AdviceService : IAdviceService
    {
        private readonly HttpClient httpClient;

        public AdviceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<AdviceModel> GetAdviceAsync()
        {
            AdviceModel retValue = new AdviceModel();
            HttpResponseMessage? response = await httpClient.GetAsync($"");
            retValue = await response.ReadContentAsync<AdviceModel>();
            return retValue;
        }
    }
}
