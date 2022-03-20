using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Math
    {
        public static int SimpleFunction(int num1) // Public method named SimpleFunction with an int parameter
        {
            int result; // Creates variable with int data type
            result = num1 + 15; // Function that uses parameter and stores value under result
            return result;
        }

        public static int SimpleFunction(decimal num1) // Parameter is decimal datatype
        {
            int result;
            result = Convert.ToInt32(num1) * 3; // Converts parameter to int data type to return result as int
            return result;
        }

        public static int SimpleFunction(string num1) // Parameter is string data type
        {
            int result;
            result = Convert.ToInt32(num1) / 4; // Converts parameter into int data type to be able to do math to it
            return result;
        }
    }
}
