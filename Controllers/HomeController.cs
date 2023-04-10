using INTEXAPP2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace INTEXAPP2.Controllers
{
    public class HomeController : Controller
    {
        private mummiesContext Context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, mummiesContext temp)
        {
            _logger = logger;
            Context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BurialRecords()
        {
            var Burials = Context.Burialmains.Take(5).ToList();
            return View(Burials);
        }

        public IActionResult SupervisedAnalysis()
        {
            return View();
        }

        public IActionResult UnsupervisedAnalysis()
        {
            return View();
        }

        public IActionResult AdministrativePages()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}