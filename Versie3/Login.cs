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
            if (b.tryLogIn( txtNaam.Text, txtWachtwoord.Text))
            {
                accLeiding acc = b.logIn(txtNaam.Text);
                MENU m = new MENU();
                m.huidigaccount = acc;
                m.Show();
                this.Hide();
            }
            else
            {
                //ww of naam fout
                MessageBox.Show("Login fout.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void txtNaam_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
