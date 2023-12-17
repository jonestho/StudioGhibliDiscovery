using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioGhibliDiscovery
{
    public class Person
    {
        // Data Grid Content
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string eye_color { get; set; }
        public string hair_color { get; set; }

        // For Individual Pages
        public string id { get; set; }
        public List<string> films { get; set; }
        public string Species { get; set; }
    }
}
