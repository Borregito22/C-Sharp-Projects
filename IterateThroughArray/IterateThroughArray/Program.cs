using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateThroughArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classicCars = { "W111", "190E", "964", "356", "Countach", "GNX", "E30" };

            Console.WriteLine("Please input some text:");
            string input = Console.ReadLine(); // Stores value of user input into input as string

            // Loop that iterates through each string in the array and adds user input to the end of each string
            for (int i = 0; i < classicCars.Length; i++)
            {
                classicCars[i] = classicCars[i] + input; // Adds user input to each element in the array
            }

            // Loop that prints off each string in the array on a separate line
            for (int j = 0; j < classicCars.Length; j++)
            {
                Console.WriteLine(classicCars[j]); // Prints each item in array on separate lines
            }
            Console.ReadLine();

            // Inifinite loop
            int a = 0;
            for (; ; ) // Creates infinite loop
            {
                if (a == 5000) // When a is equal to 5000, this block of code executes
                {
                    break; // Stops execution of the loop
                }

                Console.WriteLine("The 80s had some of the best cars.");
                a++; // Incremenets a by 1
            }
            Console.ReadLine();

            // Loop that uses comparison to determine whether to continue iterating loop
            for (int x = 0; x < 16; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

            // Loop that uses comparison to determine whether to continue iterating loop
            for (int y = 0; y <= 50; y++)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();

            // List of strings
            List<string> gameList = new List<string>(); // Creates a new list named gameList
            gameList.Add("Hunt: Showdown");
            gameList.Add("Escape From Tarkov");
            gameList.Add("The Cycle: Frontier");
            gameList.Add("Valheim");
            gameList.Add("Doom");

            Console.WriteLine("Please input text to search for in the list:");
            string userInput = Console.ReadLine(); // Stores value from user into userInput

            for (int b = 0; b < gameList.Count; b++)
            {
                if (gameList.Contains(userInput)) // Checks if user input contains a match to the list
                {
                    Console.WriteLine("The index of the matching item is: " + gameList.IndexOf(userInput)); // Displays index of matching item from input from user
                    break;
                }
                else
                {
                    Console.WriteLine("Your input is not on the list.");
                    break;
                }
            }
            Console.ReadLine();

            // List of strings
            List<string> devList = new List<string>();
            devList.Add("Battlestate Games");
            devList.Add("FromSoftware");
            devList.Add("Yager");
            devList.Add("Crytek");
            devList.Add("CD PROJEKT RED");
            devList.Add("Gamepires");
            devList.Add("Valve");
            devList.Add("4A Games");
            devList.Add("Hazelight");
            devList.Add("WarpFrog");
            devList.Add("Yager");

            Console.WriteLine("Please input text to search for in the list:");
            string devInput = Console.ReadLine(); // Stores value from user into userInput

            int devCount = 0;
            for (int c = 0; c < devList.Count; c++)
            {
                if (devInput == devList[c]) 
                {
                    Console.WriteLine("The index of the matching item is: " + devInput + " was found in: " + devCount); // Displays index of matching item from input from user
                    devCount++;
                }
                else
                {
                    Console.WriteLine("Your input was not found in position: " + devCount);
                    devCount++;
                }
            }
            Console.ReadLine();

            Console.WriteLine("Please input text to search for in the list:");
            string devInput2 = Console.ReadLine(); // Stores value from user into userInput

            int devCount2 = 0;
            foreach (string d in devList)
            {
                if (d == devInput) 
                {
                    Console.WriteLine("The index of the matching item is: " + devInput2 + " was found in: " + devCount2); // Displays index of matching item from input from user
                    devCount2++;
                }
                else
                {
                    Console.WriteLine("Your input was not found in position: " + devCount2);
                    devCount2++;
                }
            }
            Console.ReadLine();
        }
    }
}
