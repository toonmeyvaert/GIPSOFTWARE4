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
    public partial class KLUSJE : Form
    {
        private Business bus;
        public KLUSJE()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            HOOFD_KLUSJE h = new HOOFD_KLUSJE();
            h.Show();
        }

        private void KLUSJE_Load(object sender, EventArgs e)
        {
            vulForm();
        }

        public void vulForm()
        {
            bus = new Business();

            lstKlusje.Items.Clear();

            foreach (string lijn in bus.getKlusjes())
            {
                lstKlusje.Items.Add(lijn);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
