using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a List
            List<int> a = new List<int>() { 10, 20, 30, 40, 50,};

            //get values from list collection
            Console.WriteLine(a[0]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[4]);
            Console.WriteLine();

            //List with for Loop

            List<int> b = new List<int>() { 10, 40, 50, 90, 100 };

            Console.WriteLine("For Loop: ");
            for (int i = 0; i < b.Count; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.WriteLine();

            //List with foreach loop
            List<int> c = new List<int>() { 10, 30, 50, 80, 90 };

            Console.WriteLine("Foreach Loop");
            foreach (int item in c)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Add Method
            List<int> d = new List<int>() { 10, 40, 50 };
            d.Add(100);
            
            //get values from list collection
            Console.WriteLine("Add: ");
            foreach (int item in d)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Insert Method
            List<int> e = new List<int>() { 10, 40, 50, 150, 200 };
            e.Insert(2, 100);

            //get values from list collection
            Console.WriteLine("Insert: ");
            foreach (int item in e)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //AddRange Method
            List<int> f = new List<int>() { 10, 40, 50, 150, 200 };
            List<int> g = new List<int>() { 300, 400, 500 };

            f.AddRange(g);
            Console.WriteLine("AddRange: ");
            foreach (int item in f)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //InsertRange
            List<int> h= new List<int>() { 10, 40, 50, 150, 200 };
            List<int> j = new List<int>() { 60, 70, 80 };
            
            h.InsertRange(3, j);
            Console.WriteLine("InsertRange:");
            foreach (int item in h)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Remove method
            List<int> k = new List<int>() { 10, 40, 50 };
            k.Remove(40);

            Console.WriteLine("Remove: ");
            foreach (int item in k)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Contains
            List<int> l = new List<int> { 10, 20, 50, 80, 100 };

            Console.WriteLine("Resize:");
            bool m1 = l.Contains(50);
            bool m2 = l.Contains(60);
            Console.WriteLine(m1); //Output: True
            Console.WriteLine(m2); //Output: False

            Console.WriteLine();

            //Reverse
            List<int> n = new List<int> { 50, 20, 100, 30, 500, 150, 300 };
            n.Reverse();

            Console.WriteLine("Reverse:");
            foreach (int item in n)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Sort
            List<int> p = new List<int> { 50, 20, 100, 30, 500, 150, 300 };
            p.Sort();

            Console.WriteLine("Sort:");
            foreach (int item in p)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Sort Descending
            List<int> q = new List<int> { 50, 20, 100, 30, 500, 150, 300 };
            q.Sort();
            q.Reverse();

            Console.WriteLine("Sort Descending:");
            foreach (int item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //IndexOf Method
            List<int> r = new List<int>() { 10, 40, 50, 120, 200 };
            int s = r.IndexOf(50);

            Console.WriteLine("IndexOf:");
            Console.WriteLine(s); //Output: 2
            Console.WriteLine();

            //Collection Filters
            List<int> t = new List<int> { 50, 27, 105, 34, 55, 80, 100, 133 };
            List<int> u = new List<int>();

            foreach(int item in t)
            {
                if(item % 2 == 0)
                {
                    u.Add(item);
                }
            }
            Console.WriteLine("Collection Filter:");
            foreach (int item in u)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
