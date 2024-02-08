using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_14_Fibonacci_series_in_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {// Fibonacci series in given range
            Console.Write("Enter your range:\t");
            int n=int.Parse(Console.ReadLine());
            int a = 0,b=1,sum=0;
            Console.WriteLine($"The fibonacci series upto {n} are:");
            // fibonacci series less than given number
            while (a <= n)
            {
                Console.Write(a + " ");
                sum = a + b;
                a = b;
                b = sum;
            }
            // fibonacci series upto given range
            /*for(int i=1;i<=n;i++)
            {
                Console.Write(a + " ");
                sum = a + b;
                a = b;
                b = sum;
            }*/
            Console.ReadLine();
        }
    }
}
