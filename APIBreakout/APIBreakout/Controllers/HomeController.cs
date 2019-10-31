using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIBreakout.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace APIBreakout.Controllers
{
    public class HomeController : Controller
    {
        //This method calls and returns the response from our API
        public string CallStarWarsAPI(int Id)
        {
            HttpWebRequest request = WebRequest.CreateHttp("https://swapi.co/api/people/" + Id);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //This will convert the response to a string
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }

        public JToken ParseSWAPI(string text)
        {
            JToken output = JToken.Parse(text);
            return output;
        }

        public IActionResult Index()
        {
            //  ViewBag.text = CallStarWarsAPI();

            string text = CallStarWarsAPI(1);
            JToken t = ParseSWAPI(text);
            ViewBag.name = t["name"];
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Result(int Id)
        {
            string text = CallStarWarsAPI(Id);
            JToken t = JToken.Parse(text);
            Person p = new Person(t);

            return View(p);
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
