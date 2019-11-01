using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APIBreakout.Models
{
    public class StarWarsDAL
    {
        private static string baseURL = "https://swapi.co/api/";

        public static Person GetPerson(int id)
        {

            HttpWebRequest request = WebRequest.CreateHttp($"{baseURL}people/{id}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //This will convert the response to a string
            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            JToken t = ParseJsonString(APIText);

            Person p = new Person(t);

            return p;
        }

        public  static JToken ParseJsonString(string text)
        {
            JToken output = JToken.Parse(text);
            return output;
        }
    }
}
