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
        private Korisnik korisnik = null;
        public frmRegistracija(Korisnik korisnik = null)
        {
            InitializeComponent();
            Baza.OnKorisnikDodan += Baza_OnKorisnikDodan;
            this.korisnik = korisnik;
        }


        private void Baza_OnKorisnikDodan(Korisnik korisnik)
        {
            MessageBox.Show($"Event, korisnik dodan: {korisnik?.Ime}");
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren())
                {
                    if (this.korisnik == null)
                    {
                        Korisnik korisnik = new Korisnik();
                        korisnik.Ime = txtIme.Text;
                        korisnik.Prezime = txtPrezime.Text;
                        korisnik.Username = txtUsername.Text;
                        korisnik.Password = txtPassword.Text;
                        korisnik.Aktivan = chkAktivan.Checked;
                        korisnik.Uloge = clbUloge.CheckedItems.Cast<Uloga>().ToList();

                        korisnik.Validate();

                        //Baza.DodajKorisnika(korisnik, (Korisnik kparam) => { MessageBox.Show($"Korisnik dodan anonymous: {korisnik.Ime}"); });
                        Baza.DodajKorisnika(korisnik);
                        this.Close();
                    }
                    else
                    {
                        Korisnik korisnik = Baza.GetKorisnik(this.korisnik.Id);
                        korisnik.Ime = txtIme.Text;
                        korisnik.Prezime = txtPrezime.Text;
                        korisnik.Username = txtUsername.Text;
                        korisnik.Password = txtPassword.Text;
                        korisnik.Validate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void KorisnikDodan(Korisnik korisnik)
        {
            MessageBox.Show($"Korisnik dodan: {korisnik.Ime}");
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

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            clbUloge.DataSource = Uloga.Uloge;
            clbUloge.DisplayMember = "Naziv";
            
            if (korisnik != null)
            {
                //txtUsername.Enabled = false;
                txtUsername.ReadOnly = true;
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtUsername.Text = korisnik.Username;
                txtPassword.Text = korisnik.Password;
                chkAktivan.Checked = korisnik.Aktivan;
            }
        }

        private void frmRegistracija_MouseClick(object sender, MouseEventArgs e)
        {
            //Korisnik korisnik = this.korisnik;
            //korisnik.Ime = txtIme.Text;
            //korisnik.Prezime = txtPrezime.Text;
            //korisnik.Username = txtUsername.Text;
            //korisnik.Password = txtPassword.Text;
            //korisnik.Validate();
        }
    }
}
