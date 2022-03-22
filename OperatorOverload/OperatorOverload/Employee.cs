using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int Id; // Creates integer variable called Id
        
        public Employee(int x) // Method that allows instantiation of an object with a property
        {
            Id = x;
        }

        public static bool operator == (Employee employee1, Employee employee2) // Overloaded == operator to compare employee1 to employee2
        {
            if (employee1.Id == employee2.Id) // Compares Id's of employee1 and employee2
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Employee employee1, Employee employee2) // Comparison operators must be overloaded in pairs
        {
            if (employee1.Id != employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
