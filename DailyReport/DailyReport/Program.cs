using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints an introduction for the program
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Asks for name and saves it to yourName variable
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // Asks for the current course and saves value to yourCourse
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            // Asks for the current page number. Value is stored as a string and then converted to an integer
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int currentPage = Convert.ToInt32(pageNumber);

            // Asks if user needs help with specific format. Value is stored as a string and then converted to a boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(help);

            // Asks user to write positive experiences. Value is stored as a string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Asks user how many hours they studied. Value is stored as a string and then converted to an integer
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int howManyHours = Convert.ToInt32(hoursStudied);

            // After all questions are asked, this message will be displayed. ReadLine will leave the console open
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
