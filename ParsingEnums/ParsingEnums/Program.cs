using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string input = Console.ReadLine(); // Stores user input as input with string data type

            Week.DaysOfTheWeek day; // Creates variable for class
            try
            {
                day = (Week.DaysOfTheWeek)Enum.Parse(typeof(Week.DaysOfTheWeek), input); // Attempts to convert user input into an enum and stores it as day if converted
            }
            catch (Exception ex) // Block of code is executed if conversion is not successful
            {
                Console.WriteLine("Please enter an acutal day of the week.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
