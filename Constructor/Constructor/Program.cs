using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string game = "Hunt: Showdown"; // Creates a constant variable called name with string data type
            var developer = "Crytek"; // Creates a variable without implicit data type

            Construct a = new Construct(); // Calls Construct method
            Construct b = new Construct("Robbie", "Utah"); // Calls Construct method and passes two parameters
        }
    }
    public class Construct
    {
        public string name; 
        public string location;

        public Construct() // Constructor
        {
        }
        public Construct(string name, string location) // Chained Constructor
        {
            this.name = name;
            this.location = location;
        }
    }
}
