using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Array
            int[] a = new int[5] { 10, 20, 30, 40, 50 };

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
            Console.WriteLine();

            //Get the values Using For loop
            Console.WriteLine("For Loop: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();

            //Get the values Using foreach Loop
            Console.WriteLine("Foreach Loop: ");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //System.Array class methods

            //IndexOf method
            int[] b = new int[5] { 10, 20, 30, 40, 50 };
            int n = Array.IndexOf(b, 50);
            Console.WriteLine("IndexOf: " + n); //Output: 4
            Console.WriteLine();

            //Binary search
            int[] c = new int[5] { 10, 20, 30, 40, 50 };
            int m = Array.BinarySearch(c, 30);
            Console.WriteLine("Binary Search:" + m); //Output: 2
            Console.WriteLine();

            //Clear method
            int[] d = new int[5] { 10, 20, 30, 40, 50 };
            Array.Clear(d, 2, 2);

            //get values from array
            Console.WriteLine("Clear:");
            foreach (int item in d)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Resize method
            int[] e = new int[4] { 10, 30, 20, 40 };
            Array.Resize(ref e, 6);
            e[4] = 200;
            e[5] = 350;

            Console.WriteLine("Resize:");
            foreach (int item in e)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Sort method
            int[] f = new int[7] { 50, 20, 100, 30, 500, 150, 300 };
            Array.Sort(f);

            Console.WriteLine("Sort:");
            foreach (int item in f)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Reverse method
            int[] g = new int[7] { 50, 20, 100, 30, 500, 150, 300 };
            Array.Reverse(g);

            Console.WriteLine("Reverse:");
            foreach (int item in g)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //CopyTo
            int[] h = new int[5] { 10, 20, 50, 80, 100 };
            int[] j = new int[5];
            h.CopyTo(j, 0);

            Console.WriteLine("CopyTo:");
            foreach (int item in j)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Multi Dimensional array
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  

            Console.WriteLine("Multi Dimensional Array: ");
            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Console.Write(arr[k, l] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
