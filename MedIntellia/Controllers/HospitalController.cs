using DataModel;
using Microsoft.AspNetCore.Mvc;
using Service_Broker.Public;
using Service_Broker.RapidAPI;

namespace MedIntellia.Controllers
{
    public class HospitalController : Controller
    {
        private readonly ILogger<HospitalController> _logger;
        private readonly IRapidAPI_Countries country;
        private readonly ICMI_Service cmi;
        private readonly IGeoCoderService geocode;

        public HospitalController(ILogger<HospitalController> logger, IRapidAPI_Countries country, ICMI_Service cmi, IGeoCoderService geocode)
        {
            _logger = logger;
            this.country = country;
            this.cmi = cmi;
            this.geocode = geocode;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await country.GetCountriesAsync());
        }
        public async Task<IActionResult> mapAsync()
        {
            return View();
        }
        public async Task<IActionResult> map2Async()
        {
            return View();
        }
        public async Task<IActionResult> map3Async()
        {
            return View();
        }
        public async Task<IActionResult> map4Async()
        {
            return View(await geocode.GetGeoCodeAsync());
        }
        public async Task<IActionResult> DetailsAsync()
        {
            return View(await cmi.GetCMIAsync());
        }
    }
}
