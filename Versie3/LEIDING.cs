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
    public partial class LEIDING : Form
    {
        public LEIDING()
        {
            InitializeComponent();
        }

        private Business bus;

        private void LEIDING_Load(object sender, EventArgs e)
        {
            vulForm();
        }

        public void vulForm()
        {
            bus = new Business();

            lstLeiding.Items.Clear();

            foreach (string lijn in bus.getLeden())
            {
                lstLeiding.Items.Add(lijn);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLeiding_Click(object sender, EventArgs e)
        {
            btnAk.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label6.Show();
            label7.Show();
            txtAchternaam.Show();
            txtAdres.Show();
            txtGeboorte.Show();
            txtNaam.Show();
            txtTak.Show();
        }

        private void btnAk_Click(object sender, EventArgs e)
        {
            bus.voegToe(txtNaam.Text, txtGeboorte.Text, txtAdres.Text, txtTak.Text, txtAchternaam.Text);
            vulForm();
        }

        private void lstLeiding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
