using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:"); // Prompts user to enter package weight
            int weight = Convert.ToInt32(Console.ReadLine()); // Converts input to an Int and stores it as weight
            if (weight > 50) // This block of code will be run if weight is over 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0); // Closes console to prevent program from continuing
            }

            Console.WriteLine("Please enter the package width:"); // Prompts user to enter package width
            int width = Convert.ToInt32(Console.ReadLine()); // Converts input to an Int and stores it as width

            Console.WriteLine("Please enter the package height:"); // Prompts user to enter package height
            int height = Convert.ToInt32(Console.ReadLine()); // Converts input to an Int and stores it as hieght

            Console.WriteLine("Please enter the package length:"); // Prompts user to enter package length
            int length = Convert.ToInt32(Console.ReadLine()); // Converts input to an Int and stores it as length
            if (width + height + length > 50) // Functions that checks if dimensions are greater than 50. If greater, this block of code will be executed
            {
                Console.WriteLine("Package too big to be shipped via Package Express."); // Prompts user that package is too big.
                Console.ReadLine();
                Environment.Exit(0); // Closes console to prevent program from continuing
            }

            int quote = ((height * width * length) * weight) / 100; // Function that aqcuires the shipping estimate and stores it as quote
            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("$#,0.00")); // Prints shipping estimate with a specific format. quote is converted to String here for proper display
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
