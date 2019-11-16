using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    static class Baza
    {
        static public List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();

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
