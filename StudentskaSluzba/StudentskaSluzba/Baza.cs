using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    static class Baza
    {
        static int MinId = 2000;
        static Baza()
        {
            Korisnici.Add(new Korisnik() 
            {
                Id = ++MinId,
                Ime = "Amel",
                Prezime = "Musić",
                Username = "amel",
                Password = "qweasd"
            });
            for(int i = 0; i<100; i++)
            {
                Korisnici.Add(new Korisnik()
                {
                    Id = ++MinId,
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
            //var result = from r in Korisnici
            //             where (r.Ime == ime || string.IsNullOrWhiteSpace(ime))
            //                && (r.Prezime == prezime || string.IsNullOrWhiteSpace(prezime))
            //             orderby r.Prezime descending
            //             select r;

            //var tmpList = new List<Korisnik>();
            //foreach(var r in Korisnici)
            //{
            //    if (r.Ime == ime || string.IsNullOrWhiteSpace(ime)
            //                && (r.Prezime == prezime || string.IsNullOrWhiteSpace(prezime)))
            //    {
            //        tmpList.Add(r);
            //    }
            //}


            //var tmp = result.ToList();

            using (StudentskaSluzbaDbContext ctx = new StudentskaSluzbaDbContext())
            {
                var query = ctx.Korisnici.Include("Uloge").Include("Grad").AsQueryable();

                if (!string.IsNullOrWhiteSpace(ime))
                {
                    query = query.Where(NewMethod(ime));
                }

                if (!string.IsNullOrWhiteSpace(prezime))
                {
                    query = query.Where(x => x.Prezime == prezime);
                }

                if (!string.IsNullOrWhiteSpace(preskoci))
                {
                    //int br = int.Parse(preskoci);
                    int br = 0;
                    bool isValid = int.TryParse(preskoci, out br);
                    if (isValid)
                    {
                        query = query.Skip(br);
                    }
                }

                if (!string.IsNullOrWhiteSpace(uzmi))
                {
                    int br = 0;
                    bool isValid = int.TryParse(uzmi, out br);
                    if (isValid)
                    {
                        query = query.Skip(br);
                    }
                }

                query = query.OrderByDescending(x => x.Prezime);

                return query.ToList();
            }
           
        }

        private static System.Linq.Expressions.Expression<Func<Korisnik, bool>> NewMethod(string ime)
        {
            return x => x.Ime == ime;
        }

        //public static void DodajKorisnika(Korisnik korisnik, KorisnikDodan korisnikDodan)
        //{
        //    Korisnici.Add(korisnik);

        //    korisnikDodan(korisnik);
        //}

        public static void DodajKorisnika(Korisnik korisnik)
        {
            using (StudentskaSluzbaDbContext ctx = new StudentskaSluzbaDbContext())
            {
                ctx.Gradovi.Attach(korisnik.Grad);
                ctx.Spolovi.Attach(korisnik.Spol);

                ctx.Korisnici.Add(korisnik);
                
                
                ctx.SaveChanges();
            }
                //var zadnji = Korisnici.Select(x => x.Id).DefaultIfEmpty(0).Max();
                //korisnik.Id = ++zadnji;
                //Korisnici.Add(korisnik);

                //OnKorisnikDodan(korisnik);
        }

        public static void IzmjeniKorisnika(int id, Korisnik korisnik)
        {
            using (StudentskaSluzbaDbContext ctx = new StudentskaSluzbaDbContext())
            {
                var novi = ctx.Korisnici.First(x => x.Id == id);
                novi.Ime = korisnik.Ime;
                novi.Prezime = korisnik.Prezime;
                novi.Username = korisnik.Username;

                ctx.SaveChanges();
            }
        }

        public static Korisnik GetKorisnik(int id)
        {
            return Korisnici.Single(x => x.Id == id);
        }

        public static List<Grad> Gradovi()
        {
            using (StudentskaSluzbaDbContext ctx = new StudentskaSluzbaDbContext())
            {
                return ctx.Gradovi.ToList();
            }
        }

        public static List<Spolovi> Spolovi()
        {
            using (StudentskaSluzbaDbContext ctx = new StudentskaSluzbaDbContext())
            {
                return ctx.Spolovi.ToList();
            }
        }

        public static List<Uloga> Uloge()
        {
            using (StudentskaSluzbaDbContext ctx = new StudentskaSluzbaDbContext())
            {
                return ctx.Uloge.ToList();
            }
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
