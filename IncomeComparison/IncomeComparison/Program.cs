using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourly1 = Console.ReadLine(); // Stores value from user into hourly1 as a string
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine(); // Stores value from user into hours1 as a string
            double salary1 = Convert.ToDouble(hourly1) * Convert.ToDouble(hours1) * 52; // Converts hourly1 and hours1 into doubles in order to multiply them. This acquires the salary and stores the value in salary1


            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourly2 = Console.ReadLine(); // Stores value from user into hourly2 as a string
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine(); // Stores value from user into hours2 as a string
            double salary2 = Convert.ToDouble(hourly2) * Convert.ToDouble(hours2) * 52; // Converts hourly2 and hours2 into doubles in order to multiply them. This acquires the salary and stores the value in salary2

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1); // Displays salary of Person 1
            Console.WriteLine("Anuual salary of Person 2:");
            Console.WriteLine(salary2); // Displays salary of Person 2
            bool trueOrFalse = salary1 > salary2; // Checks if salary1 is greater than salary2 and stores boolean value to trueOrFalse

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(trueOrFalse); // Displays stored boolean value
            Console.ReadLine(); // Prevents console from auto closing
        }
    }
}
