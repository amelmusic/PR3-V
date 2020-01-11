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
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Spolovi> Spolovi { get; set; }
        public DbSet<Uloga> Uloge { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>()
            .HasMany<Uloga>(s => s.Uloge)
            .WithMany(c => c.Korisnici)
            .Map(cs =>
            {
                cs.MapLeftKey("KorisnikId");
                cs.MapRightKey("UlogaId");
                cs.ToTable("KorisniciUloge");
            });

            modelBuilder.Entity<Spolovi>().HasKey(x => x.Id);

            //modelBuilder.Entity<Korisnik>().HasOptional(x=> x.GradRodjenja).WithMany()

            base.OnModelCreating(modelBuilder);
        }

    }
}
