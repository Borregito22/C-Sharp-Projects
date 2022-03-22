using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1); // Instantiates Employee class with new object and passes a parameter
            Employee employee2 = new Employee(2);
            
            if (employee1 == employee2) // If loop that compares Id's between employee1 and employee2
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            Console.ReadLine();
        }
    }
}
