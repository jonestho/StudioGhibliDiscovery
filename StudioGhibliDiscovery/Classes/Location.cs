using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioGhibliDiscovery.Classes
{
    public class Location
    {
        // Data Grid Content
        public string Name { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }

        // For Individual Pages
        public string id { get; set; }
        public string surface_water { get; set; }
        public List<string> residents {  get; set; }
        public List<string> films { get; set; }
    }
}
