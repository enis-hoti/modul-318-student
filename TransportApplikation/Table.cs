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
    public partial class Table : Form
    {
        public string place;

        private SwissTransport.ITransport trans;
        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            txtplace.Text = place;
            Table_fill();
        }

        public void Table_fill()
        {
            trans = new SwissTransport.Transport();
            var stationBoard = trans.GetStationBoard("Sursee", "8502007");
            for (int i = 0; i < stationBoard.Entries.Count; i++)
            {
                string msg = stationBoard.Entries[i].To + " " + stationBoard.Entries[i].Number;
                lvdata.Items.Add(msg);
            }
        }
    }
}
