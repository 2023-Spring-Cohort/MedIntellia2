using DataModel;
using Microsoft.AspNetCore.Mvc;
using Service_Broker.NewsApi;

namespace MedIntellia.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;
        private readonly INewsServices _news;

        public NewsController(ILogger<NewsController> logger, INewsServices news)
        {
            _logger = logger;
            this._news = news;
        }

        public async Task<ActionResult<NewsModel>> Index()
        {
            _logger.LogInformation("Getting top headlines from NewsAPI...");

            NewsModel newsList = await _news.GetNewsAsync("US", 1);
            //_logger.LogInformation($"Successfully retrieved {newsList.Count} news articles." );

            return View(newsList);

        }

        [HttpGet]
        public async Task<IActionResult> Details(string Author)
        {
            Article Model = new Article();
            var list = await _news.GetNewsAsync("US", 1);
            var articles = list.articles;
            foreach(var a in articles)
            {
                if(a.author == Author)
                {
                    Model = a;
                    break;
                }

            }
            return View (Model);
        }
    }
}




