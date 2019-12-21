using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    public class Uloga
    {
        public string Naziv { get; set; }

        public static List<Uloga> Uloge = new List<Uloga>()
        {
            new Uloga() { Naziv = "Administrator"},
            new Uloga() { Naziv = "Službenik"},
            new Uloga() { Naziv = "Eksterni saradnik"},
        };
    }
}
