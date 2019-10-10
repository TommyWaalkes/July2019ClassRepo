using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class RazorAndModelController : Controller 
    {
        public IActionResult RazorBasic()
        {
            return View();
        }

        public IActionResult ModelUsing()
        {
            Fish f = new Fish();
            f.Name = "Frankie";
            ViewBag.fish = "hello world";
            return View();
        }

        public IActionResult AtModel()
        {
            Fish f = new Fish();
            f.Name = "Frankie";
            f.IsFreshWater = true;
            f.Scales = 33;
            f.Species = "Swordfish";
            //Crap this won't display Frankie, what do we doooooo?!
            return View(f);
        }

        public IActionResult List()
        {
            List<Fish> fishes = new List<Fish>();
            Fish f1 = new Fish();
            fishes.Add(new Fish("Freddie", 30, "Salmon", true));
            fishes.Add(new Fish("Gertrude", 22, "Tuna", false));
            fishes.Add(new Fish("Ally", 1230, "Flounder", false));
            return View(fishes);
        }
    }
}
