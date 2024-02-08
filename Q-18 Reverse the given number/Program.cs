using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_18_Reverse_the_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {//reverse the given number.
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());//123
            int a = 0, b = 0;
            Console.WriteLine($"Your entered digit is {n}");
            while (n != 0)
            {
                a = n % 10;
                b = (b * 10) + a;
                n /= 10;
            }
            Console.WriteLine($"Your number reverse is {b}");
            Console.ReadLine();
        }
    }
}
