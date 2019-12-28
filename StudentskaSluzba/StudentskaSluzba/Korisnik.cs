using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    [Table("Korisnik")]
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Aktivan { get; set; }
        public string Naziv => $"{Ime} {Prezime}";
        public string IB => $"IB{Id}";

        public List<Uloga> Uloge = new List<Uloga>();

        public string UlogeStr => string.Join(",", Uloge.Select(x => x.Naziv));
        //IB1800545

        public void Validate()
        {
            if (Password.Length < 3)
            {
                throw new ApplicationException("Password nije ispravan!");
            }
        }
    }
}
