using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCCoreEntity.Models;
using System.Diagnostics;


namespace MVCCoreEntity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly NorthwindContext NorthwindContext;
        public HomeController(ILogger<HomeController> logger, NorthwindContext NorthwindContext)
        {
            _logger = logger;
            this.NorthwindContext = NorthwindContext;
        }

        public IActionResult Index()
        {
            var customers = NorthwindContext.Customers.ToList();
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