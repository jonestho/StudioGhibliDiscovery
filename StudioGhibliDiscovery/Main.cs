using StudioGhibliDiscovery.Classes;
using StudioGhibliDiscovery.User_Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioGhibliDiscovery
{
    public partial class Main : Form
    {
        static Main instance;

        private List<string> pageHistory = new List<string>();
        private List<UserControl> pagesOpened = new List<UserControl>();

        private string currentPage = "";

        public Main()
        {
            InitializeComponent();
        }

        public static Main Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Main();
                }
                return instance;
            }
        }

        public Panel ControlPanel
        {
            get { return UCPanel; }
            set { UCPanel = value; }
        }

        public UserControl fetchUC(Type typeUC)
        {
            foreach(UserControl UC in pagesOpened)
                if (UC.GetType() == typeUC)
                    return UC;

            return null;
        }

        public UserControl switchPage(string pageName, Film film = null, Location loc = null, Vehicle veh = null, Species spec = null, Person pers = null)
        {
            switch (pageName)
            {
                // Pages Directly Accessed from Home
                case "UCMain":
                    UserControl main = fetchUC(typeof(UCMain));

                    if(main == null)
                    {
                        main = new UCMain();
                        pagesOpened.Add(main);
                        ControlPanel.Controls.Add(main);
                    }

                    return main;

                case "UCFilms":
                    UserControl films = fetchUC(typeof(UCFilms));

                    if (films == null)
                    {
                        films = new UCFilms();
                        pagesOpened.Add(films);
                        ControlPanel.Controls.Add(films);
                    }

                    return films;

                case "UCPeople":
                    UserControl people = fetchUC(typeof(UCPeople));

                    if (people == null)
                    {
                        people = new UCPeople();
                        pagesOpened.Add(people);
                        ControlPanel.Controls.Add(people);
                    }

                    return people;

                case "UCLocations":
                    UserControl locations = fetchUC(typeof(UCLocations));

                    if (locations == null)
                    {
                        locations = new UCLocations();
                        pagesOpened.Add(locations);
                        ControlPanel.Controls.Add(locations);
                    }

                    return locations;

                case "UCSpecies":
                    UserControl species = fetchUC(typeof(UCSpecies));

                    if(species == null){
                        species = new UCSpecies();
                        pagesOpened.Add(species);
                        ControlPanel.Controls.Add(species);
                    }

                    return species;

                case "UCVehicles":
                    UserControl vehicles = fetchUC(typeof(UCVehicles));

                    if(vehicles == null)
                    {
                        vehicles = new UCVehicles();
                        pagesOpened.Add(vehicles);
                        ControlPanel.Controls.Add(vehicles);
                    }

                    return vehicles;

                case "UCFavorites":
                    UserControl favorites = fetchUC(typeof(UCFavorites));

                    if(favorites == null)
                    {
                        favorites = new UCFavorites();
                        pagesOpened.Add(favorites);
                        ControlPanel.Controls.Add(favorites);
                    }

                    return favorites;

                // Individual Pages
                case "UCFilm":
                    UserControl filmPage = fetchUC(typeof(UCFilm));

                    if(filmPage != null)
                    {
                        ControlPanel.Controls.Remove(filmPage);
                        pagesOpened.Remove(filmPage);
                    }

                    filmPage = new UCFilm(film);
                    pagesOpened.Add(filmPage);
                    ControlPanel.Controls.Add(filmPage);

                    return filmPage;
            }

            return null;
        }

        public void displayPage(string pageName, UserControl pageObject)
        {
            try
            {
                pageObject.Dock = DockStyle.Fill;
                ControlPanel.Controls[pageName].BringToFront();

                currentPage = pageName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void nextPage(string pageName, Film film = null, Location loc = null, Vehicle veh = null, Species spec = null, Person pers = null)
        {
            pageHistory.Add(pageName);
            UserControl pageObject;

            if (film != null)
                pageObject = switchPage(pageName, film);
            else if (loc != null)
                pageObject = switchPage(pageName, null, loc);
            else if (veh != null)
                pageObject = switchPage(pageName, null, null, veh);
            else if (spec != null)
                pageObject = switchPage(pageName, null, null, null, spec);
            else if (pers != null)
                pageObject = switchPage(pageName, null, null, null, null, pers);
            else
                pageObject = switchPage(pageName);

            displayPage(pageName, pageObject);
        }

        public void previousPage(bool toHome = false)
        {
            string pageName;

            if (!toHome)
            {
                pageHistory.RemoveAt(pageHistory.Count - 1);
                pageName = pageHistory[pageHistory.Count - 1];
            }
            else
            {
                pageHistory.RemoveRange(1, pageHistory.Count - 1);
                pageName = pageHistory[0];
            }

            UserControl pageObject = switchPage(pageName);
            displayPage(pageName, pageObject);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            instance = this;
            nextPage("UCMain");
        }

        public string getJSON(string url)
        {
            string responseJSON = "";

            using (HttpClient client = new HttpClient())
            {
                Uri requestEndPoint = new Uri(url);
                responseJSON = client.GetAsync(requestEndPoint).Result.Content.ReadAsStringAsync().Result;
            }

            return responseJSON;
        }
    }
}
