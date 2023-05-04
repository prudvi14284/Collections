using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a LinkedList 
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Kiran");
            names.AddLast("Prudvi");
            names.AddLast("Sudeer");
            names.AddLast("Murali");
            names.AddFirst("Manoj");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
