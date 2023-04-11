using MedIntellia.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedIntellia.Controllers
{
    public class Test : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger<Test> logger;

        public Test(ApplicationDbContext context, ILogger<Test> logger)
        {
            this.context = context;
            this.logger = logger;

        }
        public IActionResult Index()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "this is an exception");
            }
            logger.LogInformation("Whatever you want in index");
            return View();
        }
    }
}
