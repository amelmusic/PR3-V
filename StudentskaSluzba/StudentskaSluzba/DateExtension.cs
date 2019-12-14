using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    public static class DateExtension
    {
        public static string ToBiHString(this DateTime date)
        {
            return date.ToString("dd.MM.yyyy");
        }
    }
}
