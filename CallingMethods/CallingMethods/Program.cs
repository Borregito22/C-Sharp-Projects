using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would do you want to do math operations on?");
            int input = Convert.ToInt32(Console.ReadLine()); // Converts user input into Int and stores it as input

            Console.WriteLine(input + " divided by twelve equals " + Math.DivideTwelve(input)); // Calls method DivideTwelve from class Math and uses input as perameter
            Console.WriteLine(input + " multiplied by fourty five equals " + Math.TimesFourtyFive(input)); // Calls method TimesFourtyFive from class Math and uses input as perameter
            Console.WriteLine(input + " multiplied by twenty two equals " + Math.TimesTwentyTwo(input)); // Calls method TimesTwentyTwo from class Math and uses input as perameter
            Console.ReadLine();
        }
    }
}
