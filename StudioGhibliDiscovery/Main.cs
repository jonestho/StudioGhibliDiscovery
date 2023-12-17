using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioGhibliDiscovery
{
    public partial class Main : Form
    {
        static Main instance;

        public List<string> pageHistory = new List<string>();
        private string currentPage = "";

        public Main()
        {
            InitializeComponent();
            nextPage("UCMain");
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
        
        public UserControl createNewPage(string pageName)
        {
            switch (pageName)
            {
                case "UCMain":
                    return new UCMain();
                case "UCFilms":
                    return new UCFilms();
                case "UCPeople":
                    return new UCPeople();
                case "UCLocations":
                    return new UCLocations();
                case "UCSpecies":
                    return new UCSpecies();
                case "UCVehicles":
                    return new UCVehicles();
                case "UCFavorites":
                    return new UCFavorites();
            }

            return null;
        }

        public void displayPage(string pageName, UserControl pageObject)
        {
            try
            {
                if (this.currentPage != "")
                    ControlPanel.Controls.RemoveByKey(this.currentPage);

                pageObject.Dock = DockStyle.Fill;
                ControlPanel.Controls.Add(pageObject);
                ControlPanel.Controls[pageName].BringToFront();

                this.currentPage = pageName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void nextPage(string pageName)
        {
            pageHistory.Add(pageName);

            UserControl pageObject = createNewPage(pageName);
            displayPage(pageName, pageObject);
        }

        public void previousPage()
        {
            pageHistory.RemoveAt(pageHistory.Count - 1);
            string pageName = pageHistory[pageHistory.Count - 1];

            UserControl pageObject = createNewPage(pageName);
            displayPage(pageName, pageObject);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            instance = this;
            nextPage("UCMain");
        }
    }
}
