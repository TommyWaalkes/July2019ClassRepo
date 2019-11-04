using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment6.Models;

namespace MockAssessment6.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            List<Employee> employees = db.Employee.ToList();

            return View(employees);
        }

        public IActionResult RetirementInfo(int Employee)
        {
            Employee e = db.Employee.Find(Employee);

            if(e.Age > 60)
            {
                ViewBag.canRetire = true;
            }
            else
            {
                ViewBag.canRetire = false;
            }
            
            ViewBag.benefits = decimal.Parse(0.6.ToString()) * e.Salary;

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
