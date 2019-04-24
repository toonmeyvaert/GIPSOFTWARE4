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
    public partial class Login : Form
    {
        Business b = new Business();
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (b.tryLogIn(txtNaam.Text, txtWachtwoord.Text))
            {
                accLeiding acc = b.logIn(txtNaam.Text);
                //login gelukt met het account acc
                MessageBox.Show("Ingelogt");
            }
            else
            {
                //ww of naam fout
                MessageBox.Show("Login fout.");
            }
        }
    }
}
