using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Math
    {
        public void Divide(int num1)
        {
            int result;
            result = num1 / 2;
            Console.WriteLine(result);
            return;
        }

        public static void OutputMethod(out int num1, out int num2) // Method with output parameters, Class is declared static
        {
            num1 = 7;
            num2 = 643;
        }

        public static void OutputMethod(out int num1, out int num2, out int num3) // Overloads OutputMethod
        {
            num1 = 7;
            num2 = 643;
            num3 = 3450;
        }
    }
}
