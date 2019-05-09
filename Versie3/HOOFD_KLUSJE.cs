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
    public partial class HOOFD_KLUSJE : Form
    {
        public HOOFD_KLUSJE()
        {
            InitializeComponent();
        }
        private Business bus;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bus.voegToe(txtKlusje.Text, txtVerantwoordelijke.Text, txtPlanning.Text);
            vulForm();

            txtKlusje.Text = "";
            txtVerantwoordelijke.Text = "";
            txtPlanning.Text = "";

        }

        private void HOOFD_KLUSJE_Load(object sender, EventArgs e)
        {
            vulForm();
        }

        public void vulForm()
        {
            bus = new Business();

            lvK.Items.Clear();

            foreach (KlusjeK l in bus.getKlusjes())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = l.soort;
                lvi.SubItems.Add(l.verantwoordelijke);
                lvi.SubItems.Add(l.planning);
                lvi.Tag = l; 
                lvK.Items.Add(lvi);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            KlusjeK k = (KlusjeK)lvK.SelectedItems[0].Tag;
            bus.deleteKlusje(k.soort, k.verantwoordelijke, k.planning);
            vulForm();
        }

        private void lvK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
