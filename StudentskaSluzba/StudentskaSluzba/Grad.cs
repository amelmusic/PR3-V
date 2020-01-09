using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    [Table("Gradovi")]
    public class Grad
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
