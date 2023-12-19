using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioGhibliDiscovery.Classes
{
    public class Species
    {
        // Data Grid Content
        public string Name { get; set; }
        public string Classification { get; set; }
        public string eye_colors { get; set; }
        public string hair_colors { get; set; }

        // For Individual Pages
        public string id { get; set; }
        public List<string> people { get; set; }
        public List<string> films { get; set; }

    }
}
