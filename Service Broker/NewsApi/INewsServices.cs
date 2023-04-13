using DataModel;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Broker.NewsApi
{
    public interface INewsServices
    {
        Task<NewsModel> GetNewsAsync(string country, int pageSize);
        Task GetTopHeadlinesAsync(TopHeadlinesRequest topHeadlinesRequest);
    }
}
