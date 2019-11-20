using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hiding.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Hiding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Movie()
        {
            string apiKey = Secret.APIKey;


            HttpWebRequest request = WebRequest.CreateHttp($"https://grandcircusco.github.io/demo-apis/donuts/{Secret.APIKey}.json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream s = response.GetResponseStream();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string apiText = rd.ReadToEnd();

            JToken t = JToken.Parse(apiText);

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
