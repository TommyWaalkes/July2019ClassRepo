using Lab23Breakout.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23Breakout.Controllers
{
    public class LoginController : Controller
    {
        ShopContext db = new ShopContext();
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User u)
        {
            if (db.User.Contains(u))
            {
                ViewBag.Error = "That user already exists";
                return View();
            }
            else
            {
                db.User.Add(u);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Name, string Password)
        {
            List<User> users = db.User.ToList();

            for(int i = 0; i < users.Count; i++)
            {
                User u = users[i];
                if(u.Name == Name && u.Password == Password)
                {
                    //Log in the user
                    TempData["User"] = u;
                }
            }

            ViewBag.Error = "Incorrect User name or password, please register or try again";
            return RedirectToAction("Index", "Home");
        }
    }
}
