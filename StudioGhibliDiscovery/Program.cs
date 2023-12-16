using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioGhibliDiscovery
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filmsJSON, peopleJSON, locationJSON, speciesJSON, vehicleJSON;

            using (HttpClient client = new HttpClient())
            {
                Uri filmsEndPoint = new Uri("https://ghibliapi.vercel.app/films");
                Uri peopleEndPoint = new Uri("https://ghibliapi.vercel.app/people");
                Uri locationEndPoint = new Uri("https://ghibliapi.vercel.app/films/locations");
                Uri speciesEndPoint = new Uri("https://ghibliapi.vercel.app/films/species");
                Uri vehiclesEndPoint = new Uri("https://ghibliapi.vercel.app/films/vehicles");

                filmsJSON = client.GetAsync(filmsEndPoint).Result.Content.ReadAsStringAsync().Result;
                peopleJSON = client.GetAsync(peopleEndPoint).Result.Content.ReadAsStringAsync().Result;
                locationJSON = client.GetAsync(locationEndPoint).Result.Content.ReadAsStringAsync().Result;
                speciesJSON = client.GetAsync(speciesEndPoint).Result.Content.ReadAsStringAsync().Result;
                vehicleJSON = client.GetAsync(vehiclesEndPoint).Result.Content.ReadAsStringAsync().Result;

                Console.WriteLine(filmsJSON);

            }

            // Application.Run(new Main());

        }
    }
}
