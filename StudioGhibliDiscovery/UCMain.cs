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
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void viewFilms_Click(object sender, EventArgs e)
        {
            Main.Instance.nextPage("UCFilms");
        }

        private void viewPeople_Click(object sender, EventArgs e)
        {
            Main.Instance.nextPage("UCPeople");
        }

        private void viewLocations_Click(object sender, EventArgs e)
        {
            Main.Instance.nextPage("UCLocations");
        }

        private void viewSpecies_Click(object sender, EventArgs e)
        {
            Main.Instance.nextPage("UCSpecies");
        }

        private void viewVehicles_Click(object sender, EventArgs e)
        {
            Main.Instance.nextPage("UCVehicles");
        }

        private void viewFavorites_Click(object sender, EventArgs e)
        {
            Main.Instance.nextPage("UCFavorites");
        }
    }
}
