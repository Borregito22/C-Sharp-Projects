using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable // Employee class inherits from Person class and IQuittable interface
    {
        public override void SayName() // Overrides method from original class
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit() // Inherits interface and implements Quit() method
        {
            Console.WriteLine("Console will now close.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        
    }
}
