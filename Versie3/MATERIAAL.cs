using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Versie3
{
    public partial class MATERIAAL : Form
    {
        public MATERIAAL()
        {
            InitializeComponent();
        }

        private Business bus;

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            txtNaam.Show();
            txtAantal.Show();
            txtBeschikbaarheid.Show();
            btnToev.Show();
        }

        public void vulForm()
        {
            bus = new Business();

            lstMateriaal.Items.Clear();

            foreach (string lijn in bus.getMaterialen())
            {
                lstMateriaal.Items.Add(lijn);
            }
        }

        private void btnToev_Click(object sender, EventArgs e)
        {
            bus.voegToe(txtNaam.Text, Convert.ToInt32(txtAantal.Text), txtBeschikbaarheid.Text);
            vulForm();
        }

        private void MATERIAAL_Load(object sender, EventArgs e)
        {

        }

        private void btnToevoegen_Click_1(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            txtNaam.Show();
            txtAantal.Show();
            txtBeschikbaarheid.Show();
            btnToev.Show();
        }

        private void btnToev_Click_1(object sender, EventArgs e)
        {
            bus.voegToe(txtNaam.Text, Convert.ToInt32(txtAantal.Text), txtBeschikbaarheid.Text);
            vulForm();
        }
    }
}
