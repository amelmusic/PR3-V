﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    [Table("Uloge")]
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public virtual ICollection<Korisnik> Korisnici { get; set; } = new List<Korisnik>();
    }
}
