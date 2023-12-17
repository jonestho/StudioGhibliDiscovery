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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main.Instance.previousPage();
        }
    }
}
