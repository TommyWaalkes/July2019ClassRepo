using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment5.Models;

namespace MockAssessment5.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Result(Calc c)
        {
            string operation = c.operation;
            double result = 0;
            if(operation == "plus")
            {
                result = c.num1 + c.num2;
            }
            else if (operation == "minus")
            {
                result = c.num1 - c.num2;
            }
            else if(operation == "multiply")
            {
                result = c.num1 * c.num2;
            }
            else if(operation == "divide")
            {
                result = c.num1 / c.num2;
            }
            ViewBag.result = result;
            ViewBag.operation = operation;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
