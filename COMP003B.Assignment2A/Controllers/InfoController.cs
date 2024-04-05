using COMP003B.Assignment2A.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP003B.Assignment2A.Controllers
{
    public class InfoController : Controller
    {
        
            private readonly ILogger<InfoController> _logger;

            public InfoController(ILogger<InfoController> logger)
            {
                _logger = logger;
            }

            public IActionResult About()
            {
                return View();
            }

            public IActionResult Hobbies()
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
