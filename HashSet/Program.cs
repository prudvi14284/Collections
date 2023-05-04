using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Create HashSet unique values
            HashSet<string> h = new HashSet<string>() { "Prudvi","Rajesh"};

            h.Add("Kiran");
            h.Add("Manoj");
            h.Add("Prudvi");

            foreach(string s in h)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
