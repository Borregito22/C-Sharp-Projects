using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person // Employee class inherits from Person class
    {
        public override void SayName() // Overrides method from original class
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
