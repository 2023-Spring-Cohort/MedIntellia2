using DataModel;
using NewsAPI.Models;
using Newtonsoft.Json;

namespace Service_Broker.NewsApi
{
    public class NewsServices : INewsServices
    {
        //public static readonly object Models;
        private readonly HttpClient httpClient;

        public NewsServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<NewsModel> GetNewsAsync(string country, string category, int pageNumber)
        {
            NewsModel retValue = null;
            using (StreamReader r = new StreamReader(@"Data\NewsJson.json"))
            {
                string json = r.ReadToEnd();
                retValue = JsonConvert.DeserializeObject<NewsModel>(json);
            }
            //string queryString = $"?country={country}095cc7074c704ed98af13b157f821b1f&apiKey=&Page={pageNumber}";
            ////?country ={ default}
            ////&apiKey ={ 8aad4f749acc42569b7a2f187088237e}
            //NewsModel retValue = new NewsModel();
            //try
            //{

          //     HttpResponseMessage? response = await httpClient.GetAsync($"https://newsapi.org/v2/top-headlines?country=US&category=health&apiKey=095cc7074c704ed98af13b157f821b1f&Page=1");
        //        retValue = await response.ReadContentAsync<NewsModel>();

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
            return retValue;
        }

        public Task GetTopHeadlinesAsync(TopHeadlinesRequest topHeadlinesRequest)
        {
            throw new NotImplementedException();
        }
    }
}
