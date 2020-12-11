// Create a test programs that uses optional parameters, named parameter and variable number of parameters.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //optional Parameters
            optionalParameters("Westley", "Cho", "male", "student");
            optionalParameters("Westley", "Cho");
            namedArguments(lname: "Cho", fname: "Westley");
            Console.ReadLine();
        }
        static public void optionalParameters(string fname, string lname, string gender = "N/A", string occupation = "student")
        {
            Console.WriteLine(fname);
            Console.WriteLine(lname);
            Console.WriteLine(gender);
            Console.WriteLine(occupation);
        }
        static public void namedArguments(string fname, string lname)
        {
            Console.WriteLine($"First Name: {fname}, Last Name: {lname}");
        }
    }
    
}
