using Lab23Breakout.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23Breakout.Controllers
{
    public class ProductController : Controller
    {
        ShopContext db = new ShopContext();

        public IActionResult Index()
        {
            List<Products> products = db.Products.ToList();
            return View(db.Products.ToList());
        }

        public IActionResult Buy(int id)
        {
            Products p = db.Products.Find(id);
            if(p!= null)
            {
                return View(p);
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }
    }
}
