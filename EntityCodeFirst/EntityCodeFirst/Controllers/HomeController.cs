using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityCodeFirst.Models;

namespace EntityCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public StudentContext db = new StudentContext();
        public IActionResult Index()
        {
            List<Student> students = db.Students.ToList();
            ViewBag.list = students;
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

        //this is for displaying the view 
        public IActionResult Create()
        {
            return View();
        }

        //this is for handling the form input 
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(s);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
