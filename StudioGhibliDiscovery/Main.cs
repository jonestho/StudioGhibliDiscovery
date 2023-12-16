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
    public partial class Main : Form
    {
        static Main instance;
        public LinkedList<string> pageHistory = new LinkedList<string>();

        public Main()
        {
            InitializeComponent();
            pageHistory.AddFirst("Main");
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
        
        public UserControl createNewPage(string name)
        {
            // Add a switch statement with cases that represent each interface.

            return null;
        }
    }
}
