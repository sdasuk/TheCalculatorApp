using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using TheCalculatorApp.Models;
using TheCalculatorApp.Services;

namespace TheCalculatorApp.Controllers
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(InputDataModel inputData)
        {
            if (ModelState.IsValid)
            {
                var cal = new CalculateService();

                decimal result = 0;

                var typeOfCalculation = Request.Form["probDropdownList"].ToString();

                switch (typeOfCalculation)
                {
                    case "1":
                        result = cal.CalculateUsingFirstFunction(inputData);
                        break;
                    case "2":
                        result = cal.CalculateUsingSecondFunction(inputData);
                        break;
                    default:
                        result = 0;
                        break;
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}, {1}, {2}, {3}, {4}", DateTime.Today, typeOfCalculation, inputData.FirstNumber, inputData.SecondNumber, result);
                
                var logService = new LogService();
                logService.WriteLog(sb.ToString());

                ViewBag.Result = result;
            }
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