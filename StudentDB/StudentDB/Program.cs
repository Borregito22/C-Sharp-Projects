using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new SchoolContext())
            {
                var stud = new Student() { FirstName = "Carl", LastName = "Saucy", Address = "1776 Freedom Ave" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
