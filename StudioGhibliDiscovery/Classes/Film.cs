using StudioGhibliDiscovery.Classes;
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
        public string original_title_romanised { get; set; }
        public string image { get; set; }
        public string description { get; set; }

        // Hidden
        public string url { get; set; }
        public string id { get; set; }
    }
}
