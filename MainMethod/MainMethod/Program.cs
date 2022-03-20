using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math SimpleFunction = new Math(); // Instantiates the class
            int input = 35; // Creates int variable
            Console.WriteLine(input + " plus fifteen equals " + Math.SimpleFunction(input)); // Pulls method SimpleFunction from class Math and uses input as parameter
            Console.ReadLine();

            decimal input2 = 40.2m; // Creates decimal variable
            Console.WriteLine(input2 + " times three equals " + Math.SimpleFunction(input2)); // Pulls method SimpleFunction from class Math and uses input2 as parameter
            Console.ReadLine();

            string input3 = "50"; // Creates string variable
            Console.WriteLine(input3 + " divided by four equals " + Math.SimpleFunction(input3)); // Pulls method SimpleFunction from class Math and uses input3 as parameter
            Console.ReadLine();
        }
    }
}
