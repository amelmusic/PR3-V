using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzba
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var isValid = Baza.Login(txtUsername.Text, txtPassword.Text);

            if (isValid)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Korisnicko ime ili password nisu ispravni");
            }
        }
    }
}
