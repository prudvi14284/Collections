using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary collection
            Dictionary<string, int> Marks = Marks = new Dictionary<string, int>();

            //add items (Key, value)
            Marks.Add("Maths", 90);
            Marks.Add("Physics", 70);
            Marks.Add("Chemistry", 85);

            //Get the key and value
            foreach(KeyValuePair<string, int> pair in Marks)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
            Console.WriteLine();

            //Get value based on key
            int m = Marks["Physics"];
            Console.WriteLine(m);

            Console.ReadKey();


        }
    }
}
