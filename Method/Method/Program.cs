using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); // Instantiates the class

            int input, input2, result; // Creates 3 variables with integer data types

            Console.WriteLine("Please pick a number:");
            input = Convert.ToInt32(Console.ReadLine()); // Converts user input into an integer and stores it as input

            Console.WriteLine("Please pick another number. This is optional:");
            if (int.TryParse(Console.ReadLine(), out input2)) // Checks to see if user entered anything
            {
                result = math.OptionalParameterFunction(num1: input, num2: input2); // Passes both input and input2 as parameters
                Console.WriteLine(input + " multiplied by " + input2 + " equals " + result);

            }
            else
            {
                result = math.OptionalParameterFunction(input); // Only uses input as parameter and uses default value for input2
                Console.WriteLine(input + " multiplied by " + "seven" + " equals " + result);

            }
            Console.ReadLine();
        }
    }
}
