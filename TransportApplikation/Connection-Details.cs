using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApplikation
{
    public partial class Connection_Details : Form
    {
        public string departure;
        public string arrival;
        public string departuretime;
        public string arrivaltime;
        public string duration;
        public Connection_Details()
        {
            InitializeComponent();
        }

        private void Connection_Details_Load(object sender, EventArgs e)
        {
            lbldeparture.Text = departure + " " + departuretime;
            lblarrival.Text = arrival + " " + arrivaltime;
            lbltime.Text = duration;
        }
    }
}
