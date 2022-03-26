using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); // Instantiates Employee class

            new Employee() { Id = 1, firstName = "Joe", lastName = "Schmo" }; // Adds new object to Employee class
            new Employee() { Id = 2, firstName = "Andrew", lastName = "Schmo" };
            new Employee() { Id = 8, firstName = "Joe", lastName = "Schmo" };

            //employees.Add(new Tuple<string, string, int>("Joe", "Smith", 1));
            //employees.Add(new Tuple<string, string, int>("John", "Johnson", 2));
            //employees.Add(new Tuple<string, string, int>("Bill", "Brown", 3));
            //employees.Add(new Tuple<string, string, int>("Tom", "Williams", 4));
            //employees.Add(new Tuple<string, string, int>("Jane", "Jones", 5));
            //employees.Add(new Tuple<string, string, int>("Joe", "Garcia", 6));
            //employees.Add(new Tuple<string, string, int>("Mary", "Miller", 7));
            //employees.Add(new Tuple<string, string, int>("Sarah", "Davis", 8));
            //employees.Add(new Tuple<string, string, int>("Lisa", "Martinez", 9));
            //employees.Add(new Tuple<string, string, int>("Sandra", "Anderson", 10));

            List<Employee> Joe = new List<Employee>(); // Creates new list called Joe and inherits Employee class

            foreach (var employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    Joe.Add(employee); // Adds item to list if equal to "Joe"
                    Console.WriteLine("{0} {1} {2}", employee.firstName, employee.lastName, employee.Id);
                    Console.ReadLine();
                }
            }

            List<Employee> Joe2 = employees.Where(x => x.firstName == "Joe").ToList();
            Joe2.ForEach(x => Console.WriteLine(x.firstName));

            List<Employee> Joe3 = employees.Where(x => x.Id > 5).ToList();
            Joe3.ForEach(x => Console.WriteLine(x.firstName));

            Console.ReadLine();
        }
    }
}
