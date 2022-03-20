using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Math
    {
        public int OptionalParameterFunction(int num1, int num2 = 7) // Creates two parameters with int data types. num2 has a default value
        {
            int result;
            result = num1 * num2;
            return result;
        }
    }
}
