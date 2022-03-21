using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person // Creates an abstract class which prevents instantiation
    {
        public string firstName;
        public string lastName;

        public virtual void SayName() // Creates a virtual method named SayName to allow Employee to use it
        {
            
        }
    }
}
