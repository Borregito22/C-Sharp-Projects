using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine(); // Stores value into yourAge variable as a string
            int yearsOld = Convert.ToInt32(yourAge); // Converts yourAge string into Int and is stored as yearsOld

            Console.WriteLine("Have you ever had a DUI? Please answer with \"true\" or \"false\"");
            string dui = Console.ReadLine(); // Stores values into dui as a string
            bool trueOrFalse = Convert.ToBoolean(dui); // Converts dui into a bool and is stored as trueOrFalse

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine(); // Stores value into tickets as a string
            int  speedingTickets= Convert.ToInt32(tickets); // Converts tickets into Int and stores it as speedingTickets

            Console.WriteLine("Qualified?");
            bool qualified = (yearsOld > 15 && trueOrFalse == false && speedingTickets < 3); // Compares stored values to predetermined values. All 3 values must be true to qualify. The bool value is stored as qualified
            Console.WriteLine(qualified); // Prints whether or not person qualifies for insurance
            Console.ReadLine();
        }
    }
}
