using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; // Gets current date and time of local computer
            Console.WriteLine(now); // Prints now variable to console
            Console.WriteLine("Please enter a number:");
            int input = Convert.ToInt32(Console.ReadLine()); // Converts user input to an integer and stores it as input
            DateTime hoursFromNow = now.AddHours(input); // Takes current time and adds user input to it as hours. Value is stored as hoursFromNow
            Console.WriteLine(hoursFromNow); // Prints time it will be in X hours
            Console.ReadLine();
        }
    }
}
