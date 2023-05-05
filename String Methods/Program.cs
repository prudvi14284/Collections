using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hi Kiran";
            string s2 = "Hello Prudvi";

            // Length
            Console.WriteLine("Length of s1: " + s1.Length);
            Console.WriteLine();

            // IndexOf
            Console.WriteLine("Index of : " + s1.IndexOf("Prudvi"));
            Console.WriteLine();

            // ToUpper
            Console.WriteLine("Uppercase s1: " + s1.ToUpper());
            Console.WriteLine();

            // ToLower
            Console.WriteLine("Lowercase s2: " + s2.ToLower());
            Console.WriteLine();

            // Substring
            Console.WriteLine("Substring of s1: " + s1.Substring(2, 4));
            Console.WriteLine();

            // Replace
            Console.WriteLine("Replacing : " + s2.Replace("Prudvi", "Rajesh"));
            Console.WriteLine();

            // Split
            string[] words = s1.Split(',');
            Console.WriteLine("Splitting s1: ");
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();

            // Trim
            string s3 = "   Hello, World!   ";
            Console.WriteLine("Trimming whitespace: " + s3.Trim());

            Console.WriteLine();
            // Concatenate
            Console.WriteLine("Concatenating s1 and s2: " + string.Concat(s1, " ", s2));
            Console.WriteLine("Concatenating s1 and s2: " + (s1 + " " + s2));
            Console.ReadKey();
        }
    }
}
