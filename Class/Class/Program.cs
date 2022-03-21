using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); // Instantiates the class

            Console.WriteLine("Please enter a number:");
            int input = Convert.ToInt32(Console.ReadLine()); // Stores user input as input as an integer

            math.Divide(input); // Passes input as parameter to class method
            Console.ReadLine();


        }
    }
}
