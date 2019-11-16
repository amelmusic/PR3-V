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
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren())
                {
                    Korisnik korisnik = new Korisnik();
                    korisnik.Ime = txtIme.Text;
                    korisnik.Prezime = txtPrezime.Text;
                    korisnik.Username = txtUsername.Text;
                    korisnik.Password = txtPassword.Text;
                    korisnik.Validate();
                    Baza.Korisnici.Add(korisnik);
                    this.Close();
                }
            } 
            //catch(Exception ex)
            finally
            {
                MessageBox.Show("", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }
        }
    }
}
