using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sorted List Key value pair ascending order
            SortedList<string, int> Marks = new SortedList<string, int>() { };

            Marks.Add("Maths", 95);
            Marks.Add("Physics", 90);
            Marks.Add("Chemistry", 85);

            //Get Key Value pair
            Console.WriteLine("SortedList: ");
            foreach(KeyValuePair<string, int> pair in Marks)
            {
                Console.WriteLine(pair.Key + " "+ pair.Value);
            }
            Console.WriteLine();

            //Get value based on key
            int m = Marks["Physics"];
            Console.WriteLine(m);

            Console.ReadKey();
        }
    }
}
