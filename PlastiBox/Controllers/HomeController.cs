using Microsoft.AspNetCore.Mvc;
using PlastiBox.Models;
using System.Diagnostics;

namespace PlastiBox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contacto()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetTime(){
            DateTime time = DateTime.Now;
            string response = "{\"time\": \""+time+"\"}"; /* Formato de hora estructurado en un formato JSon */
            return Json(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
