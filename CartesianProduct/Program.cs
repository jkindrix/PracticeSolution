using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartesianProductLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set creation using the parameterless constructor
            Set<string> stringSet = new Set<string>()
            {
                Elements = { "x", "y", "z" }
            };

            // Set creation using the overloaded constructor
            Set<int> intSet = new Set<int>(new List<int>() { 1, 2, 3 });

            // Creating the Cartesian Product from the two sets
            CartesianProduct<string, int> product = new CartesianProduct<string, int>(stringSet, intSet);

            // Writing the string representation of the cartesian product to the console
            foreach (OrderedPair<string, int> x in product.ResultSet.Elements)
            {
                Console.WriteLine(x.ToString());
            }
            
            // Prevent the console window from closing
            Console.ReadLine();
        }
    }
}
