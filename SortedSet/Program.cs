using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Sortedset ascending order no duplicate values
            SortedSet<string> names = new SortedSet<string>() { };
            names.Add("Prudvi");
            names.Add("Kiran");
            names.Add("Peter");
            names.Add("Rajesh");
            names.Add("Vimal");

            // Iterate SortedSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
