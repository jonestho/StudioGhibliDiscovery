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
    public partial class UCVehicles : UserControl
    {
        public UCVehicles()
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
            vehiclesDataGrid.DataSource = Main.Instance.vehicles;

            vehiclesDataGrid.Columns[1].HeaderText = "Class";

            for(int i = 3; i < vehiclesDataGrid.Columns.Count; i++)
                vehiclesDataGrid.Columns[i].Visible = false;
        }
    }
}
