using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine(); // Stores user input as input as string data type
            var path = Path.Combine(Directory.GetCurrentDirectory(), "log.txt"); // Gets current working directory of application and checks for log.txt file. Value is stored as CWD
            //Console.WriteLine(path); // Writes file path to console
            File.WriteAllText(path, input); // Creates a file in the path and uses variable input as the value to store
            string text = File.ReadAllText(path); // Creates variable called text as a string data type. Value is the text inside of the CWD path
            Console.WriteLine(text); // Prints value of variable
            Console.ReadLine();
        }
    }
}
