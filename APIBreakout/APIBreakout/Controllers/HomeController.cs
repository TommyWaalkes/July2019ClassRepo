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
       public string CallBeerAPI()
        {
            string key = "48e769ab3f324bf2753fde2bc06e1fbc";
            HttpWebRequest request = WebRequest.CreateHttp($"https://sandbox-api.brewerydb.com/v2/beers/?key={key}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //This will convert the response to a string
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }
        
        //This method calls and returns the response from our API
        public string CallStarWarsAPI(int Id, string type)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"https://swapi.co/api/{type}/{Id}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //This will convert the response to a string
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }

        public JToken ParseJsonString(string text)
        {
            JToken output = JToken.Parse(text);
            return output;
        }

        public string CallSWAPIPlanet(int Id)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"https://swapi.co/api/planet/{Id}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //This will convert the response to a string
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }

        public IActionResult Index()
        {
            //  ViewBag.text = CallStarWarsAPI();

            Person luke = StarWarsDAL.GetPerson(1);
            ViewBag.name = luke.Name;

            //string beerText = CallBeerAPI();
            //JToken t2 = ParseJsonString(beerText);

            //ViewBag.beer = t2.ToString();
            return View();
        }

        public IActionResult Planet()
        {
            string planetData = CallSWAPIPlanet(1);
            JToken p = ParseJsonString(planetData);

            return View();
        }

        public IActionResult Search()
        {
            return View();
        }


        public IActionResult Result(int Id, string Type)
        {
            string text = CallStarWarsAPI(Id, Type);
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
