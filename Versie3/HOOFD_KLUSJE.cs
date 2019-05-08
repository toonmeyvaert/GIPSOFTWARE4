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
        }

        private void HOOFD_KLUSJE_Load(object sender, EventArgs e)
        {
            vulForm();
        }

        public void vulForm()
        {
            bus = new Business();

            lstK.Items.Clear();

            foreach (string lijn in bus.getKlusjes())
            {
                lstK.Items.Add(lijn);
            }
        }

        private void txtVerantwoordelijke_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKlusje_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPlanning_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPlanning_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
