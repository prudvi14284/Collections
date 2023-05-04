using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create SorteDictionary unique values
            SortedDictionary<string, string> names = new SortedDictionary<string, string>() { };
            names.Add("1", "Prudvi");
            names.Add("4", "Rajesh");
            names.Add("5", "Kiran");
            names.Add("3", "Manoj");
            names.Add("2", "Ram");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.ReadKey();
        }
    }
}
