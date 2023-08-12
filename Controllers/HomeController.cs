using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
 
using library;
using System.Text.Json;

namespace CalculatorApp.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [HttpPost]
        public IActionResult Calculate([FromBody] JsonElement data)
        {
            try
            {
                string expression = data.GetProperty("expression").GetString();
                Debug.WriteLine(expression);
                var calculator = new Calculator();
                int result = calculator.Calculate(expression);
                // Save the calculation history or perform any necessary actions
                return Json(new { success = true, result });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = "Error evaluating expression: " + ex.Message });
            }
        }


    }
}