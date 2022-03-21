using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" }; // Instantiates employee class and adds values to variables
            employee.SayName(); // Calls SayName method on new employee object
            Console.ReadLine();
        }
    }
}
