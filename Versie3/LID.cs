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
    public partial class LID : Form
    {
        public LID()
        {
            InitializeComponent();
        }

        private Business bus;

        private void LID_Load(object sender, EventArgs e)
        {
            vulForm();
        }

        public void vulForm()
        {
            bus = new Business();

            lstLid.Items.Clear();

            foreach (string lijn in bus.getLeden())
            {
                lstLid.Items.Add(lijn);
            }

        }

        private void btnAk_Click(object sender, EventArgs e)
        {
            bus.voegToe(txtNaam.Text, txtGeboorte.Text, txtMed.Text, txtAdres.Text, txtEmail.Text, txtTak.Text, txtAchternaam.Text);
            vulForm();
        }

        private void lstLid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLid_Click(object sender, EventArgs e)
        {
            btnAk.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            txtAchternaam.Show();
            txtAdres.Show();
            txtEmail.Show();
            txtGeboorte.Show();
            txtMed.Show();
            txtNaam.Show();
            txtTak.Show();  
        }
    }
}
