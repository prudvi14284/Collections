using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create  ArrayList collection non generic type
            ArrayList MyData = new ArrayList() { };

            //add items
            MyData.Add(100);
            MyData.Add(100.2398);
            MyData.Add("hyderabad");
            MyData.Add(true);
            MyData.Add(DateTime.Now);

            //get items from the ArrayList collection
            for (int i = 0; i < MyData.Count; i++)
            {
                Console.WriteLine(MyData[i]);
            }
            Console.ReadKey();
        }
    }
}
