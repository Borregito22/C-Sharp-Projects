using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); // Instantiates Employee class with a new object as type List<string>
            employee.things = new List<string>() { "Name", "Address", "Department", "Supervisor", "Email", "Number" }; // Adds list of strings to things property to employee

            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>() { 4, 5, 8, 23, 15, 63, 75, 24 };

            for (int i=0; i < employee.things.Count; i++)
            {
                Console.WriteLine(employee.things[i]); // Prints each item in list
            }
            for (int i = 0; i < employee1.things.Count; i++)
            {
                Console.WriteLine(employee1.things[i]);
            }
            Console.ReadLine();
        }
    }
}
