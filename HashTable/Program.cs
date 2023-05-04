using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create Hashtable collection, it is non generic type
            Hashtable Marks = new Hashtable() { };

            //add items (keys and values)
            Marks.Add("Maths", 86);
            Marks.Add("Physics", 67);
            Marks.Add("Chemistry", 78);
            Marks.Add("StudentName", "scott");
            Marks.Add("IsRegistered", true);

            //get value based on the key
            int m = Convert.ToInt32(Marks["Physics"]);
            Console.WriteLine(m);

            //get value based on the key (another example)
            bool b = Convert.ToBoolean(Marks["IsRegistered"]);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
