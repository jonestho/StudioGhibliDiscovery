using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioGhibliDiscovery.User_Controls
{
    public partial class UCFilm : UserControl
    {
        private Film film;
        public UCFilm(Film film)
        {
            this.film = film;
            InitializeComponent();
            populateFilmPage();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main.Instance.previousPage();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Main.Instance.previousPage(true);
        }

        private void populateFilmPage()
        {
            filmName.Text = $"{film.title} ({film.original_title_romanised})";
        }
    }
}
