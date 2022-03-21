using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        public string FirstName; // Creates a property called FirstName with string data type
        public string LastName;

        public void SayName() // Void method to write the person's full name
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
