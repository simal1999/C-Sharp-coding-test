using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_5_swapping_two_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:\t");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:\t");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine($"Before swapping a and b values are {a},{b}.");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swapping a and b values are {a},{b}.");
            Console.ReadLine();
        }
    }
}
