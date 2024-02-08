using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_15_Fibonacci_series_sum_of_numbers_up_to_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {// Fibonacci series sum  of numbers upto given range.
            Console.Write("Enter your range:\t");
            int n=int.Parse(Console.ReadLine());
            int a = 0,b=1,c=0,sum=0;
            while (a <= n)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
                sum += a;
            }
            Console.Write($"\nThe sum of numbers of fibonacci upto {n} is {sum}.");
            Console.ReadLine();
        }
    }
}
