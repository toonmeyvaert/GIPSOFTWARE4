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
    public partial class MENU : Form
    {
        public accLeiding huidigaccount;
        public MENU()
        {
            InitializeComponent();
        }

        private void lidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LEDEN frm = new LEDEN();
            frm.ShowDialog();
        }

        private void MenuLeiding_Click(object sender, EventArgs e)
        {
            LEIDING frm = new LEIDING();
            frm.ShowDialog();
        }

        private void MenuAankoop_Click(object sender, EventArgs e)
        {
            AANKOOP frm = new AANKOOP();
            frm.ShowDialog();
        }

        private void MenuMateriaal_Click(object sender, EventArgs e)
        {
            MATERIAAL frm = new MATERIAAL();
            frm.ShowDialog();
        }

        private void MenuKlusje_Click(object sender, EventArgs e)
        {
            KLUSJE frm = new KLUSJE();
            frm.ShowDialog();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
