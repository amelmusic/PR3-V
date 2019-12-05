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
    public partial class frmKorisniciLista : Form
    {
        public frmKorisniciLista()
        {
            InitializeComponent();
            Baza.OnKorisnikDodan += Baza_OnKorisnikDodan;
            dgvKorisniciList.AutoGenerateColumns = false;
        }

        private void Baza_OnKorisnikDodan(Korisnik obj)
        {
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            dgvKorisniciList.DataSource = null;
            dgvKorisniciList.DataSource = Baza.Korisnici;
        }

        private void frmKorisniciLista_Load(object sender, EventArgs e)
        {
            ucitajPodatke();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            ucitajPodatke();
        }

        private void dgvKorisniciList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = (Korisnik)dgvKorisniciList.SelectedRows[0].DataBoundItem;

            frmRegistracija frm = new frmRegistracija(selectedRow);
            frm.Show();
        }
    }
}
