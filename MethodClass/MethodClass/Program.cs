using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); // Instantiates the class
            int input = 7; // Creates integer variable
            int input2 = 15;

            math.Display(num1: input, num2: input2); // Passes input and input2 as parameters for the class method
            Console.ReadLine();
        }
    }
}
