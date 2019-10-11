using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User u)
        {
            TempData["name"] = u.UserName;
            TempData["password"] = u.Password;
            return RedirectToAction("Secret");
        }
        
        public IActionResult Secret()
        {
            //Why won't the password show up in our view?
            //ViewBag.password = TempData.Peek("password");
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult SetColor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetColor(string color)
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(2);
            Response.Cookies.Append("color", color, option);
            return View();
        }
    }
}