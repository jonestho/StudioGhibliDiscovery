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
    public partial class UCLocations : UserControl
    {
        public UCLocations()
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
            locationsDataGrid.DataSource = Main.Instance.locations;

            for (int i = 3; i < locationsDataGrid.Columns.Count; i++)
                locationsDataGrid.Columns[i].Visible = false;
        }
    }
}
