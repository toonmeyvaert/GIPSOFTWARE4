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
    public partial class AANKOOP : Form
    {
        public AANKOOP()
        {
            InitializeComponent();
        }

        private Business bus;

        private void AANKOOP_Load(object sender, EventArgs e)
        {
            vulForm();
        }

        public void vulForm()
        {
            bus = new Business();

            lstAankoop.Items.Clear();

            foreach (string lijn in bus.getAankopen())
            {
                lstAankoop.Items.Add(lijn);
            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            
        }

        private void AANKOOP_Load_1(object sender, EventArgs e)
        {

        }

        private void btnVoegToe_Click_1(object sender, EventArgs e)
        {
            bus.voegToe(Convert.ToDouble(txtPrijs.Text), Convert.ToInt32(txtAantal.Text), Convert.ToString(txtVoorwerp.Text));
            vulForm();
        }

        private void txtVoorwerpa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
