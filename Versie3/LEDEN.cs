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
    public partial class LEDEN : Form
    {
        public LEDEN()
        {
            InitializeComponent();
        }
        private Business bus;
        private void LEDEN_Load(object sender, EventArgs e)
        {
            vulForm();
        }

        public void vulForm()
        {
            bus = new Business();

            lvLeden.Items.Clear();

            foreach (LidK l in bus.getLeden())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = l.naam;
                lvi.SubItems.Add(l.geboorte);
                lvi.SubItems.Add(l.medisch);
                lvi.SubItems.Add(l.adres);
                lvi.SubItems.Add(l.email);
                lvi.SubItems.Add(l.tak);
                lvi.SubItems.Add(l.achternaam);
                lvi.Tag = l;
                lvLeden.Items.Add(lvi);
            }
        }

        private void btnAk_Click(object sender, EventArgs e)
        {
            bus.voegToe(txtNaam.Text, txtGeboorte.Text, txtMed.Text, txtadres.Text, txtEmail.Text, cmbTak.Text, txtAchternaam.Text);
            vulForm();
        }

        private void lstLid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLid_Click(object sender, EventArgs e)
        {

        }

        private void txtTak_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAk_Click_1(object sender, EventArgs e)
        {



            bus.voegToe(txtNaam.Text, txtGeboorte.Text, txtMed.Text, txtadres.Text, txtEmail.Text, cmbTak.Text, txtAchternaam.Text);
            vulForm();

            txtNaam.Text = "";
            txtGeboorte.Text = "";
            txtMed.Text = "";
            txtadres.Text = "";
            txtEmail.Text = "";
            cmbTak.Text = "";
            txtAchternaam.Text = "";



        }

        private void txtAdres_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnLid_Click_1(object sender, EventArgs e)
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
            txtadres.Show();
            txtEmail.Show();
            txtGeboorte.Show();
            txtMed.Show();
            txtNaam.Show();
            cmbTak.Show();
           
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadres_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void txtMed_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbTak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTak_onItemSelected(object sender, EventArgs e)
        {

        }

        private void lvLeden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

