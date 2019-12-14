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
            for(int i = 0; i<100; i++)
            {
                Korisnici.Add(new Korisnik()
                {
                    Ime = "Denis",
                    Prezime = $"Mušić{i}",
                    Username = $"denis{i}",
                    Password = "qweasd"
                });
            }
            
        }
        public delegate void KorisnikDodan(Korisnik korisnik);

        //public static event KorisnikDodan OnKorisnikDodan;
        public static event Action<Korisnik> OnKorisnikDodan;
        static public List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();

        static public long KorisniciCount(string ime = null, string prezime = null)
        {
            var korisnici = KorisniciPretraga(ime, prezime);
            var query = korisnici.AsQueryable();
            return query.Count();
        }

        static public List<Korisnik> KorisniciPretraga(string ime = null, string prezime = null, string preskoci = null, string uzmi = null)
        {
            var result = from r in Korisnici
                         where (r.Ime == ime || string.IsNullOrWhiteSpace(ime))
                            && (r.Prezime == prezime || string.IsNullOrWhiteSpace(prezime))
                         orderby r.Prezime descending
                         select r;
            
            var tmpList = new List<Korisnik>();
            foreach(var r in Korisnici)
            {
                if (r.Ime == ime || string.IsNullOrWhiteSpace(ime)
                            && (r.Prezime == prezime || string.IsNullOrWhiteSpace(prezime)))
                {
                    tmpList.Add(r);
                }
            }
           

            var tmp = result.ToList();
            var query = Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(ime))
            {
                query = query.Where(x => x.Ime == ime);
            }

            if (!string.IsNullOrWhiteSpace(prezime))
            {
                query = query.Where(x => x.Prezime == prezime);
            }

            if (!string.IsNullOrWhiteSpace(preskoci)) {
                int br = int.Parse(preskoci);
                query = query.Skip(br);
            }

            if (!string.IsNullOrWhiteSpace(uzmi))
            {
                int br = int.Parse(uzmi);
                query = query.Take(br);
            }

            query = query.OrderByDescending(x => x.Prezime);

            return query.ToList();
        }
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
