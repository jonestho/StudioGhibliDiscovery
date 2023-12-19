using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioGhibliDiscovery
{
    public class Film
    {
        // Data Grid Content
        public string title { get; set; }
        public string original_title { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string release_date { get; set; }
        public string running_time { get; set; }
        public string rt_score { get; set; }

        // For Individual Pages
        public string id { get; set; }
        public string original_title_romanised { get; set; }
        public string image { get; set; }
        public string movie_banner { get; set; }
        public string description { get; set; }
        public List<string> people { get; set; }
        public List<string> species { get; set; }
        public List<string> locations { get; set; }
        public List<string> vehicles { get; set; }
    }
}
