using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzba
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Baza.OnKorisnikDodan += Baza_OnKorisnikDodan;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiMain());
        }

        private static void Baza_OnKorisnikDodan(Korisnik korisnik)
        {
            MessageBox.Show("Iz program.cs: " + korisnik.Ime);
        }
    }
}
