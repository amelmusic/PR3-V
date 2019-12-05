using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    static class Baza
    {
        static Baza()
        {
            Korisnici.Add(new Korisnik() 
            {
                Ime = "Amel",
                Prezime = "Musić",
                Username = "amel",
                Password = "qweasd"
            });

            Korisnici.Add(new Korisnik() 
            {
                Ime = "Denis",
                Prezime = "Mušić",
                Username = "denis",
                Password = "qweasd"
            });
        }
        public delegate void KorisnikDodan(Korisnik korisnik);

        //public static event KorisnikDodan OnKorisnikDodan;
        public static event Action<Korisnik> OnKorisnikDodan;
        static public List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();

        //public static void DodajKorisnika(Korisnik korisnik, KorisnikDodan korisnikDodan)
        //{
        //    Korisnici.Add(korisnik);

        //    korisnikDodan(korisnik);
        //}

        public static void DodajKorisnika(Korisnik korisnik)
        {

            Korisnici.Add(korisnik);

            OnKorisnikDodan(korisnik);
        }
        static public bool Login(string username, string password)
        {
            foreach(var item in Korisnici)
            {
                if (item.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase)
                    && item.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
