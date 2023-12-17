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
    public partial class Main : Form
    {
        static Main instance;
        public List<string> pageHistory = new List<string>();

        public Main()
        {
            InitializeComponent();

            UCMain mainPage = new UCMain();
            mainPage.Dock = DockStyle.Fill;
            ControlPanel.Controls.Add(mainPage);

            pageHistory.Add("UCMain");
        }

        public static Main Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Main();
                }
                return instance;
            }
        }

        public Panel ControlPanel
        {
            get { return UCPanel; }
            set { UCPanel = value; }
        }
        
        public UserControl createNewPage(string pageName)
        {
            // Add a switch statement with cases that represent each interface.

            switch (pageName)
            {
                case "UCMain":
                    UCMain main = new UCMain();
                    return main;
            }

            return null;
        }
    }
}
