using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Math
    {
        static public int DivideTwelve(int num1) // Function named DivideTwelve with int data type, num1 is the parameter and is int data type
        {
            int result; // Creates integer variable called result
            result = num1 / 12; // Divides parameter by 12 and stores it as result
            return result; // Reterns result 
        }

        static public int TimesTwentyTwo(int num1)
        {
            int result;
            result = num1 * 22;
            return result;
        }

        static public int TimesFourtyFive(int num1)
        {
            int result;
            result = num1 * 45;
            return result;
        }
    }
}
