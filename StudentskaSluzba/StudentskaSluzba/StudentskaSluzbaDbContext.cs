using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    public class StudentskaSluzbaDbContext : DbContext
    {
         public StudentskaSluzbaDbContext()
            : base("SSContext")
        {

        }
        public DbSet<Korisnik> Korisnici { get; set; }
    }
}
