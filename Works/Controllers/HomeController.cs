using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Works.Controllers.Base;
using Works.Models;

namespace Works.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration configure, HttpClient httpClient) 
            : base(configure, httpClient)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
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