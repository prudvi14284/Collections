using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Queue FIFO
            Queue<string> names = new Queue<string>();
            names.Enqueue("Prudvi");
            names.Enqueue("Manoj");
            names.Enqueue("Rajesh");
            names.Enqueue("Kiran");
            names.Enqueue("Sudeer");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine("Peek element: " + names.Peek());//Prudvi
            Console.WriteLine("Dequeue: " + names.Dequeue());//Prudvi
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());//Mano
            Console.ReadKey();
        }
    }
}
