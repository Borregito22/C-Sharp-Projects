using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(); // Instantiates Number class with a new object
            number.Amount = 7; // Sets value to Amount property in Number.number
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
