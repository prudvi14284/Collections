using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Stack LIFO
            Stack<string> names = new Stack<string>();
            names.Push("Rajesh");
            names.Push("Peter");
            names.Push("Prudvi");
            names.Push("Vinodh");
            names.Push("Surya");
            names.Push("Jack");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine("Peek element: " + names.Peek()); //Jack
            Console.WriteLine("Pop: " + names.Pop()); //Jack
            Console.WriteLine("After Pop, Peek element: " + names.Peek()); //Surya
            Console.ReadKey();
        }
    }
}
