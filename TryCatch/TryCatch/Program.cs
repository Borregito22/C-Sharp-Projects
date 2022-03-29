using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = false;
            var today = DateTime.Today;
            var age = 0;

            try
            {
                Console.WriteLine("What is your age?");
                input = int.TryParse(Console.ReadLine(), out age); // Converts user input into an integer as age
                if (age <= 0) throw new ArgumentException(); // Throws an exception if user input is less than or equal to 0
                var yearBorn = today.Year - age; // Function to determine year someone was born in
                Console.WriteLine("If your birthday is after January 1st, you were born in: {0}, if not, subtract 1 from the answer.", yearBorn);
                Console.ReadLine();
            }
            catch (ArgumentException) // This block of code is executed if an ArgumentException is thrown
            {
                Console.WriteLine("Please do not enter zero or negative numbers.");
                Console.ReadLine();
                return;
            }
            catch (Exception) // This is executed if any other exceptions are thrown
            {
                Console.WriteLine("An error has occurred.");
                Console.ReadLine();
                return;
            }
        }
    }
}
