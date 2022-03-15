using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop to get sum of first 7 numbers
            int i = 0, sum = 0; // i and sum initialized to 0
            while (i <= 7) // Loop terminates when value of i reaches 7
            {
                sum += i; // Value of sum is updated to sum+i
                i++; // Value of i is incremented by 1 every iteration
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadLine();

            // Do While loop to print multiplication table of 12
            int x = 1, n = 12, product;
            do
            {
                product = n * x; // Function to calcualte product
                Console.WriteLine("{0} * {1} = {2}", n, x, product); // Prints value of product with a specific format
                x++; // Value of x is incremented by 1
            }
            while (x <= 12); // Loop is terminated when value of x equals 12
            Console.ReadLine();
        }
    }
}
