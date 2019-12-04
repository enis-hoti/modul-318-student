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
    public partial class Connection : Form
    {
        public string departure;
        public string arrival;
        public string eTime;

        private SwissTransport.ITransport trans;
        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            txtarrival.Text = arrival;
            txtdeparture.Text = departure;
            txttime.Text = time;
            getconnections();
        }

        public void getconnections()
        {
            trans = new SwissTransport.Transport();
            var connections = trans.GetConnections(txtdeparture.Text, txtarrival.Text);
            lvdata.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                string msg = txtdeparture.Text + " -> " + txtarrival.Text + "\t\t " + connections.ConnectionList[i].From.Departure.Remove(0, 11).Remove(5, 8) + "-" + connections.ConnectionList[i].To.Arrival.Remove(0, 11).Remove(5, 8) + "\t\t\t Dauer: " + connections.ConnectionList[i].Duration.Remove(0, 3).Remove(5, 3);
                lvdata.Items.Add(msg);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            getconnections();
        }

        private void lvdata_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            trans = new SwissTransport.Transport();
            var connections = trans.GetConnections(departure, arrival);
            Connection_Details ccd = new Connection_Details();
            ccd.arrival = txtarrival.Text;
            ccd.arrivaltime = connections.ConnectionList[lvdata.Items.IndexOf(lvdata.SelectedItems[0])].To.Arrival.Remove(0, 11).Remove(5, 8);
            ccd.departure = txtdeparture.Text;
            ccd.departuretime = connections.ConnectionList[lvdata.Items.IndexOf(lvdata.SelectedItems[0])].From.Departure.Remove(0, 11).Remove(5, 8);
            ccd.duration = connections.ConnectionList[lvdata.Items.IndexOf(lvdata.SelectedItems[0])].Duration.Remove(0, 3).Remove(5, 3);
            ccd.Show();
        }
    }
}
