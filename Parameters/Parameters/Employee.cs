using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Employee<T> // Gives class a generic type parameter
    {
        public List<T> things { get; set; } // Sets property called things as generic list data type
    }
}
