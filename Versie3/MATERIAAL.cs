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

            lvMateriaal.Items.Clear();

            foreach (MateriaalK l in bus.getMaterialen())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = l.naam;
                lvi.SubItems.Add(l.aantal.ToString());
                lvi.SubItems.Add(l.beschikbaarheid);
                lvi.Tag = l;
                lvMateriaal.Items.Add(lvi);
            }
        }

        private void btnToev_Click(object sender, EventArgs e)
        {
            bus.voegToe(txtNaam.Text, Convert.ToInt32(txtAantal.Text), txtBeschikbaarheid.Text);
            vulForm();
        }

        private void MATERIAAL_Load(object sender, EventArgs e)
        {
            vulForm();
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
            bus.voegToe(txtNaam.Text, txtAantal.Text, txtBeschikbaarheid.Text);
            vulForm();

            txtAantal.Text = "";
            txtNaam.Text = "";
            txtBeschikbaarheid.Text = "";

        }

        private void lvMateriaal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReserveren_Click(object sender, EventArgs e)
        {

        }
    }
}
