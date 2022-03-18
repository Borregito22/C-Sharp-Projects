using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> intList = new List<double>();
            intList.Add(2.0);
            intList.Add(5.0);
            intList.Add(7.0);
            intList.Add(10.0);
            intList.Add(11.0);
            intList.Add(14.0);
            intList.Add(22.0);
            intList.Add(24.0);
            intList.Add(1005.0);
            intList.Add(5000.0);

            
            try
            {
                Console.WriteLine("Please provide a number to divide each number in the list by:");
                double input = Convert.ToDouble(Console.ReadLine()); // Converts user input into Double and stores it as input
                for (int i = 0; i < intList.Count; i++)
                {
                    var result = intList[i] / input; // Function that divides user input by each item in the list
                    Console.WriteLine(intList[i] + " divided by " + input + " equals " + result);
                }
            }
            catch (FormatException ex) // Raises exception if user types a string
            {
                Console.WriteLine("Please type a number" + ex);
            }
            finally // This block of code is executed at the end of the loop regardless of outcome
            {
                Console.ReadLine();
            }
            Console.WriteLine("Program has emerged from the try/catch block and continued on with program execution.");
            Console.ReadLine();
        }
    }
}
