using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment7.Models;
using Newtonsoft.Json.Linq;

namespace MockAssessment7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(int Id)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"https://grandcircusco.github.io/demo-apis/donuts/{Id}.json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream s = response.GetResponseStream();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string apiText = rd.ReadToEnd();

            JToken t = JToken.Parse(apiText);

            Donut d = new Donut(t);
            ViewBag.Id = Id;


            return View(d);
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
