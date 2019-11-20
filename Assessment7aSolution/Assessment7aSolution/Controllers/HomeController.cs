using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment7aSolution.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Assessment7aSolution.Controllers
{
    public class HomeController : Controller
    {
        public List<AnimalListing> GetAnimals()
        {
            HttpWebRequest request = WebRequest.CreateHttp("https://gc-zoo.surge.sh/api/animals.json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string ApiText = rd.ReadToEnd();

            JToken tokens = JToken.Parse(ApiText);

            List<JToken> ts = tokens["results"].ToList();

            List<AnimalListing> animals = new List<AnimalListing>();

            foreach(JToken t in ts)
            {
                AnimalListing a = new AnimalListing(t);
                animals.Add(a);
            }

            return animals;
        }

        public AnimalInfo GetAnimalInfo(string species)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"https://gc-zoo.surge.sh/api/species/{species}.json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string ApiText = rd.ReadToEnd();

            JToken token = JToken.Parse(ApiText);

            AnimalInfo result = new AnimalInfo(token);

            return result;
        }
        public IActionResult Index()
        {
            List<AnimalListing> animals = GetAnimals();
            return View(animals);
        }

        public IActionResult Species(string AnimalSpecies)
        {
            AnimalInfo a = GetAnimalInfo(AnimalSpecies);

            return View(a);
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
