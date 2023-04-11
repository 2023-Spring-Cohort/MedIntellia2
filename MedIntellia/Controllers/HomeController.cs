
using MedIntellia.Models;
using Microsoft.AspNetCore.Mvc;
using Service_Broker.Public;
using Service_Broker.RapidAPI;
using System.Diagnostics;

namespace MedIntellia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdviceService advice;

        public HomeController(ILogger<HomeController> logger, IAdviceService advice, IRapidAPI_Countries country)
        {
            _logger = logger;
            this.advice = advice;
        }

        public async Task<ActionResult> Index()
        {
            return View();
        }
        //[Route("Hospital/map4")]
        public async Task<ActionResult> Map4()
        {
            return View($"../Hospital/map4");

        }

        public async Task<ActionResult> Advice()
        {
            return View(await advice.GetAdviceAsync());
        }
        //public async Task<ActionResult> Countries()
        //{
        //    return View(await country.GetCountriesAsync());
        //}

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult LatestNews()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        //public IActionResult LogIn()
        //{
        //    return View();
        //}

        //public IActionResult Register()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}