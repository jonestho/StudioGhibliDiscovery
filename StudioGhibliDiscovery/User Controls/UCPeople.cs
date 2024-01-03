using Newtonsoft.Json;
using StudioGhibliDiscovery.Classes;
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
    public partial class UCPeople : UserControl
    {
        private DataGridView dataGridBackup = new DataGridView();
        private bool initialized = false;

        public UCPeople()
        {
            InitializeComponent();
            setFilters();
            populateDataGridView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main.Instance.previousPage();
        }

        public void setFilters()
        {
            foreach (Film film in Main.Instance.films)
                sortByFilm.Items.Add(film.title);

            sortByGender.Items.Add("Male");
            sortByGender.Items.Add("Female");
            sortByGender.Items.Add("NA");

            foreach (Species species in Main.Instance.species)
                sortBySpecies.Items.Add(species.Name);
        }

        public void populateDataGridView()
        {
            if (!initialized)
            {
                peopleDataGrid.DataSource = Main.Instance.people;
                dataGridBackup.DataSource = peopleDataGrid;

                initialized = true;
            }
            else
                peopleDataGrid.DataSource = dataGridBackup.DataSource;

            peopleDataGrid.Columns[3].HeaderText = "Eye Color";
            peopleDataGrid.Columns[4].HeaderText = "Hair Color";

            bool found;

            foreach (DataGridViewRow row in peopleDataGrid.Rows)
            {
                found = false;

                foreach (Species species in Main.Instance.species)
                {
                    if (species.url == row.Cells[5].Value.ToString())
                    {
                        row.Cells[5].Value = species.Name;
                        found = true;

                        break;
                    }
                }

                if (!found)
                    row.Cells[5].Value = "NA";
            }

            for (int i = 6; i < peopleDataGrid.Columns.Count; i++)
                peopleDataGrid.Columns[i].Visible = false;

        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            Hashtable filmTitles = new Hashtable();

            foreach(Film film in Main.Instance.films)
            {
                filmTitles.Add(film.title, film.url);
            }                                          
        }
    }
}
