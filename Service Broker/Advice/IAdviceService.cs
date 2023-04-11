using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Broker.Public
{
    public interface IAdviceService
    {
        Task<AdviceModel> GetAdviceAsync();
    }
}
