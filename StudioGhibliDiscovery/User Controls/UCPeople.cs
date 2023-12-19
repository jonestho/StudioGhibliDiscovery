using Newtonsoft.Json;
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
        public UCPeople()
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
            string peopleJSON = Main.Instance.getJSON("https://ghibliapi.vercel.app/people");
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(peopleJSON);

            peopleDataGrid.DataSource = people;

            peopleDataGrid.Columns[3].HeaderText = "Eye Color";
            peopleDataGrid.Columns[4].HeaderText = "Hair Color";

            for (int i = 5; i < peopleDataGrid.Columns.Count; i++)
                peopleDataGrid.Columns[i].Visible = false;
        }
    }
}
