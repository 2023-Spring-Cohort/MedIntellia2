using DataModel;
using NewsAPI.Models;

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

        public async Task<NewsModel> GetNewsAsync(string country, int pageNumber)
        {
            string queryString = $"?country={country}&apiKey=8aad4f749acc42569b7a2f187088237e&Page={pageNumber}";
            //?country ={ default}
            //&apiKey ={ 8aad4f749acc42569b7a2f187088237e}
            NewsModel retValue = new NewsModel();
            try
            {

                HttpResponseMessage? response = await httpClient.GetAsync($"https://newsapi.org/v2/top-headlines?country=US&apiKey=8aad4f749acc42569b7a2f187088237e&Page=1");
                retValue = await response.ReadContentAsync<NewsModel>();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retValue;
        }

        public Task GetTopHeadlinesAsync(TopHeadlinesRequest topHeadlinesRequest)
        {
            throw new NotImplementedException();
        }
    }
}
