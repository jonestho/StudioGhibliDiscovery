using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioGhibliDiscovery.Classes
{
    public class Vehicle
    {
        // Data Grid Content
        public string Name { get; set; }
        public string vehicle_class { get; set; }
        public string Length { get; set; }

        // For Individual Pages
        public string id { get; set; }
        public string pilot {  get; set; }
        public List<string> films { get; set; }
    }
}
