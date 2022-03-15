using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "\"Problems that remain persistently insoluble should always be suspected as questions asked in the wrong way.\"";
            string quoteName = "\nAlan Watts"; // \n makes it go to a new line
            string alive = "\n1915 - 1973";

            Console.WriteLine(quote + quoteName + alive); // Concatenates three strings
            Console.ReadLine();

            string yelling = "Yell at the top of your lungs!";
            yelling = yelling.ToUpper(); // Converts string to uppercase

            Console.WriteLine(yelling);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder(); // Creates instance of class StringBuilder

            // AppendLine adds a new line of text
            sb.AppendLine("In God of War, players control Kratos, a Spartan warrior who is sent by the Greek gods to kill Ares, the god of war.");
            sb.AppendLine("As the story progresses, Kratos is revealed to be Ares’ former servant, who had been tricked into killing his own family and is haunted by terrible nightmares.");
            sb.AppendLine("Armed with the Blades of Chaos, a weapon made out of two daggers attached to chains, Kratos rumbles through ancient Athens and other locations on a murderous quest to terminate the rogue god.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
