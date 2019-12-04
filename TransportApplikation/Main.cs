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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void btnconnectionsearch_Click(object sender, EventArgs e)
        {
            string departure = txtconnectiondeparture.Text;
            string arrival = txtconnectionarrival.Text;
            string time = txtconnectiontime.Text;

            Connection c = new Connection();
            c.departure = departure;
            c.arrival = arrival;
            c.time = time;
            c.Show();
        }

        private void btntablesearch_Click(object sender, EventArgs e)
        {
            string place = txttableplace.Text;
            Table t = new Table();
            t.place = place;
            t.Show();
        }
    }
}
