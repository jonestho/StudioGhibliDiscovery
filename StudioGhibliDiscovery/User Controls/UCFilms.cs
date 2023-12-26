﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace StudioGhibliDiscovery
{
    public partial class UCFilms : UserControl
    {
        private List<Film> films;
        public UCFilms()
        {
            InitializeComponent();
            populateDataGridView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main.Instance.previousPage();
        }

        private void populateDataGridView()
        {
            string filmsJSON = Main.Instance.getJSON("https://ghibliapi.vercel.app/films");
            films = JsonConvert.DeserializeObject<List<Film>>(filmsJSON);

            filmsDataGrid.DataSource = films;

            filmsDataGrid.Columns[0].HeaderText = "Title";
            filmsDataGrid.Columns[1].HeaderText = "Original Title";
            filmsDataGrid.Columns[4].HeaderText = "Year Released";
            filmsDataGrid.Columns[5].HeaderText = "Running Time";
            filmsDataGrid.Columns[6].HeaderText = "Rating (Rotten Tomatoes)";

            for(int i = 7; i < filmsDataGrid.Columns.Count; i++)
                filmsDataGrid.Columns[i].Visible = false;
        }

        private void filmsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Film selectedFilm = null;
            DataGridViewRow selectedRow = filmsDataGrid.SelectedRows[0]; // Only one can be selected.

            foreach(Film film in films)
            {
                if(film.id == selectedRow.Cells[7].Value.ToString()) // Compare IDs
                {
                    selectedFilm = film;
                    break;
                }
            }

            Main.Instance.nextPage("UCFilm", selectedFilm);
        }
    }
}
