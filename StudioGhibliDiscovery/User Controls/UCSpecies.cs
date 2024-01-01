using Newtonsoft.Json;
using StudioGhibliDiscovery.Classes;
using System;
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
    public partial class UCSpecies : UserControl
    {
        public UCSpecies()
        {
            InitializeComponent();
            populateDataGridView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main.Instance.previousPage();
        }

        public void populateDataGridView()
        {
            speciesDataGrid.DataSource = Main.Instance.species;

            speciesDataGrid.Columns[2].HeaderText = "Eye Colors";
            speciesDataGrid.Columns[3].HeaderText = "Hair Colors";

            for(int i = 4; i < speciesDataGrid.Columns.Count; i++)
                speciesDataGrid.Columns[i].Visible = false;
        }
    }
}
