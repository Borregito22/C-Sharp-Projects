using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDay = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" }; // Creates a one-dimensional array of strings
            Console.WriteLine("Please select an index of the array.");
            int userInput = int.Parse(Console.ReadLine()); // Converts user input into int and stores it as userInput
            if (userInput > 6) // If chosen index is greater than total elements, this block of code executes
            {
                Console.WriteLine("Chosen index does not exist.");
                Console.ReadLine();
                Environment.Exit(0); // Terminates the console
            }
            Console.WriteLine("Value at chosen index is: " + weekDay[userInput]);
            Console.ReadLine();

            int[] squared = new int[] { 2, 4, 16, 256, 65536 }; // Creates a one-dimensional array of integers
            Console.WriteLine("Please select an index of the array.");
            int input = int.Parse(Console.ReadLine()); // Converts user input into int and stores it as input
            if (input > 4) // If chosen index is greater than total elements, this block of code executes
            {
                Console.WriteLine("Chosen index does not exist.");
                Console.ReadLine();
                Environment.Exit(0); // Terminates the console
            }
            Console.WriteLine("Value at chosen index is: " + squared[input]); // Prints value of chosen index        
            Console.ReadLine();

            List<string> listOfStrings = new List<string> // Creates a list of strings
            {
                "Broad Canyon",
                "Butterfield Canyon",
                "Cane Wash",
                "Chicken Corners",
                "Chiulos Canyon Road",
                "Elberta Slant Road",
                "Fins and Things",
                "Gemini Bridges"
            };
            Console.WriteLine("Please select an index of the array.");
            int listInput = int.Parse(Console.ReadLine()); // Converts user input into int and stores it as listInput
            Console.WriteLine("Value at chosen index is: " + listOfStrings[listInput]); // Prints value of chosen index        
            Console.ReadLine();
        }
    }
}
