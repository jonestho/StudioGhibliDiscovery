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
        private Size originalSize;

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

            peopleDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            peopleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            originalSize = new Size(peopleDataGrid.Width, peopleDataGrid.Height);
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            peopleDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            peopleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            peopleDataGrid.Size = originalSize;

            resetFilters();

            string filterFlag = "";

            string filmFilter = (sortByFilm.SelectedItem == null) ? null: sortByFilm.SelectedItem.ToString();
            string genderFilter = (sortByGender.SelectedItem == null) ? null : sortByGender.SelectedItem.ToString();
            string speciesFilter = (sortBySpecies.SelectedItem == null) ? null : sortBySpecies.SelectedItem.ToString();

            filterFlag += (filmFilter == null) ? "0" : "1";
            filterFlag += (genderFilter == null) ? "0" : "1";
            filterFlag += (speciesFilter == null) ? "0" : "1";

            string filmUrl = filmFilter == null ? null : Main.Instance.filmURLMappings[filmFilter].ToString();

            List<string> filmsIncluded;
            string gender, species;

            try
            {
                if (filmFilter == null && genderFilter == null && speciesFilter == null)
                    throw new Exception("No filter(s) applied.");

                foreach(DataGridViewRow row in peopleDataGrid.Rows)
                {
                    string sequence = "";

                    filmsIncluded = (List <string>) Main.Instance.personIDFilmMappings[row.Cells[6].Value.ToString()];
                    gender = row.Cells[1].Value.ToString();
                    species = row.Cells[5].Value.ToString();

                    if(filmUrl != null)
                        if (filmsIncluded.Contains(filmUrl))
                            sequence += "1";
                        else
                            sequence += "0";
                    else
                        sequence += "0";

                    if (genderFilter != null)
                        if (gender == genderFilter)
                            sequence += "1";
                        else
                            sequence += "0";
                    else
                        sequence += "0";

                    if (speciesFilter != null)
                        if (species == speciesFilter)
                            sequence += "1";
                        else
                            sequence = "0";
                    else
                        sequence += "0";

                    if (sequence != filterFlag)
                    {
                        CurrencyManager currencyManager = (CurrencyManager) BindingContext[peopleDataGrid.DataSource];
                        currencyManager.SuspendBinding();
                        row.Visible = false;

                        currencyManager.ResumeBinding();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void resetFilters()
        {
            foreach (DataGridViewRow row in peopleDataGrid.Rows)
                row.Visible = true;
        }

        private void resetFilter_Click(object sender, EventArgs e)
        {
            resetFilters();
        }
    }
}
