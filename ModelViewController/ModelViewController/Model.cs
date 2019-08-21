using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class Model
    {
        List<string> Names { get; set; }
        public Model()
        {
            Names = new List<string>();
            Names.Add("Tommy");
            Names.Add("joey");
            Names.Add("Phil");
            Names.Add("Billy");
            Names.Add("Notorious T Wizzle");
        }
        public string GetName(int index)
        {
            return Names[index];
        }

        public List<string> GetAllNames()
        {
            return Names;
        }
    }
}
