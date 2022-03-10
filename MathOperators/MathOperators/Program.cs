using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine(); // Stores value to input
            double product = Convert.ToDouble(input) * 50; // Converts input to Double and multiplies by 50
            Console.WriteLine("Your input multiplied by fifty = " + product); // Prints answer to console
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string input2 = Console.ReadLine(); // Stores value to input
            double add = Convert.ToDouble(input2) + 25; // Converts input to Double and adds 25 to it
            Console.WriteLine("Your input plus twenty-five = " + add); // Prints answer to console
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string input3 = Console.ReadLine(); // Stores value to input
            double div = Convert.ToDouble(input3) / 12.5; // Converts input to Double and divides it by 12.5
            Console.WriteLine("Your input divided by twelve and a half = " + div); // Prints answer to console
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string input4 = Console.ReadLine(); // Stores value to input
            bool trueOrFalse = Convert.ToDouble(input4) > 50; // Converts input to Double and checks if input is greater than 50
            Console.WriteLine("Is your input greater than fifty? " + trueOrFalse); // Prints answer to console
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string input5 = Console.ReadLine(); // Stores value to input
            int remainder = Convert.ToInt32(input5) % 7; // Converts input to Int and divides by 7. Only the remainder is stored
            Console.WriteLine("Your input divided by seven has a remainder of: " + remainder); // Prints remainder to console
            Console.ReadLine();
        }
    }
}
