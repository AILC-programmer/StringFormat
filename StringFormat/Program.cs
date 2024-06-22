using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace StringFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            float n2 = 2.656824F;

            // Composite formatting

            WriteLine("First number: {0}\nSecond number: {1}", n1, n2);

            // String interpolation

            WriteLine("This is interpolation");
            WriteLine("..........................");
            WriteLine($"First number: {n1}\nSecond number {n2}");

            // Formatting currency

            WriteLine($"Price: {n2:C1}");
            WriteLine($"Price: {n2:C}");

            // Formatting number
            // Makes numbers more readable.
            
            WriteLine($"number: {n2:N}");
            WriteLine($"number: {n2:N3}");

            // Formatting percentage

            WriteLine($"Percent: {n2:P2}");

            ReadKey();

        }
    }
}
