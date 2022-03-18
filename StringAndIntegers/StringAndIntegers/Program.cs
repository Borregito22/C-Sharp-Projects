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
            List<decimal> intList = new List<decimal>();
            intList.Add(2);
            intList.Add(5);
            intList.Add(7);
            intList.Add(10);
            intList.Add(11);
            intList.Add(14);
            intList.Add(22);
            intList.Add(24);
            intList.Add(1005);
            intList.Add(5000);

            
            try
            {
                Console.WriteLine("Please provide a number to divide each number in the list by:");
                decimal input = Convert.ToDecimal(Console.ReadLine()); // Converts user input into Decimal and stores it as input
                for (int i = 0; i < intList.Count; i++)
                {
                    var result = intList[i] / input; // Function that divides user input by each item in the list
                    Console.WriteLine(intList[i] + " divided by " + input + " equals " + result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero. " + ex);
            }
            catch (FormatException ex) // Raises exception if user types a string
            {
                Console.WriteLine("Please type a number " + ex);
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
