using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Broker.Public
{
    public interface ICMI_Service
    {
        Task<List<HospitalData>> GetCMIAsync(int id=1000);
        Task<List<HospitalData>> GetCMI_Details_Async(string state);
    }

}