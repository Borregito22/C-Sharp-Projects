using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Tuple<string, string, int>("Joe", "Smith", 1));
            employees.Add(new Tuple<string, string, int>("John", "Johnson", 2));
            employees.Add(new Tuple<string, string, int>("Bill", "Brown", 3));
            employees.Add(new Tuple<string, string, int>("Tom", "Williams", 4));
            employees.Add(new Tuple<string, string, int>("Jane", "Jones", 5));
            employees.Add(new Tuple<string, string, int>("Joe", "Garcia", 6));
            employees.Add(new Tuple<string, string, int>("Mary", "Miller", 7));
            employees.Add(new Tuple<string, string, int>("Sarah", "Davis", 8));
            employees.Add(new Tuple<string, string, int>("Lisa", "Martinez", 9));
            employees.Add(new Tuple<string, string, int>("Sandra", "Anderson", 10));

            List<Employee> Joe = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.Item1 == "Joe")
                {
                    Console.WriteLine("{0} {1} {2}", employee.Item1, employee.Item2, employee.Item3);
                }
            }

            employees.ForEach(x => x.Item1 == "Joe").ToList();
            
            Console.ReadLine();
        }
    }
}
