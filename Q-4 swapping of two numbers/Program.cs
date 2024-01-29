using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_4_swapping_of_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {//swapping two numbers.
            Console.WriteLine("Enter first number:\t");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:\t");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine($"Before swapping a and b values is\t {a},{b}");
            (a,b)=(b,a);
            Console.WriteLine($"After swapping a and b values is\t {a},{b}");
            Console.ReadLine();
        }
    }
}
